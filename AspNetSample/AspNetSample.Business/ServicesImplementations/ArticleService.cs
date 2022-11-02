﻿using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;
using AspBetSample.DataBase.Entities;
using AspNetSample.Business.Models;
using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AutoMapper;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AspNetSample.Business.ServicesImplementations;

public class ArticleService : IArticleService
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    private readonly IUnitOfWork _unitOfWork;


    public ArticleService(IMapper mapper, 
        IConfiguration configuration, 
        IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _configuration = configuration;
        _unitOfWork = unitOfWork;
    }


    public async Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync(int pageNumber,
        int pageSize)
    {
        try
        {
            var myApiKey = _configuration.GetSection("UserSecrets")["MyApiKey"];
            //_configuration.
            var list = await _unitOfWork.Articles
                .Get()
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
                .Select(article => _mapper.Map<ArticleDto>(article))
                .ToListAsync();

            return list;
        }
        catch (Exception e)
        {
            //todo add logger here
            throw;
        }
       
    }

    public async Task AggregateArticlesFromExternalSourcesAsync()
    {
        var sources = await _unitOfWork.Sources.GetAllAsync();
        
        foreach (var source in sources)
        {
            await GetAllArticleDataFromRssAsync(source.Id, source.RssUrl);
            await AddArticleTextToArticlesAsync();
        }
    }

    public async Task<List<ArticleDto>> GetArticlesByNameAndSourcesAsync(string? name, Guid? sourceId)
    {
        var list = new List<ArticleDto>();

        var entities = _unitOfWork.Articles.Get();

        if (!string.IsNullOrEmpty(name))
        {
            entities = entities.Where(dto => dto.Title.Contains(name));
        }

        if (sourceId!=null && !Guid.Empty.Equals(sourceId))
        {
            entities = entities.Where(dto => dto.SourceId.Equals(sourceId));
        }

        var result = (await entities.ToListAsync())
            .Select(ent => _mapper.Map<ArticleDto>(ent))
            .ToList();
        return result;
    }

    public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
    {
        var entity =  await _unitOfWork.Articles.GetByIdAsync(id);
        var dto = _mapper.Map<ArticleDto>(entity);

        return dto;
    }

    public async Task<int> CreateArticleAsync(ArticleDto dto)
    {
        var entity = _mapper.Map<Article>(dto);

        if (entity!= null)
        {
            await _unitOfWork.Articles.AddAsync(entity);
            var addingResult = await _unitOfWork.Commit();
            return addingResult;
        }
        else
        {
            throw new ArgumentException(nameof(dto));
        }
    }

    public async Task<int> UpdateArticleAsync(Guid id, ArticleDto? dto)
    {
        var sourceDto = await GetArticleByIdAsync(id);

        //should be sure that dto property naming is the same with entity property naming
        var patchList = new List<PatchModel>();
        if (dto != null)
        {
            if (!dto.Title.Equals(sourceDto.Title))
            {
                patchList.Add(new PatchModel()
                {
                    PropertyName = nameof(dto.Title),
                    PropertyValue = dto.Title
                });
            }
        }

        await _unitOfWork.Articles.PatchAsync(id, patchList);
        return await _unitOfWork.Commit();
    }

    public async Task GetAllArticleDataFromRssAsync()
    {
        var sources = await _unitOfWork.Sources.GetAllAsync();

        Parallel.ForEach(sources, (source) => GetAllArticleDataFromRssAsync(source.Id, source.RssUrl).Wait());
    }
 
    public async Task AddArticleTextToArticlesAsync()
    {
        var articlesWithEmptyTextIds = _unitOfWork.Articles.Get()
            .Where(article => string.IsNullOrEmpty(article.Text))
            .Select(article => article.Id)
            .ToList();

        foreach (var articleId in articlesWithEmptyTextIds)
        {
            await AddArticleTextToArticleAsync(articleId);
        }
    }

    public async Task AddRateToArticlesAsync()
    {
        var articlesWithEmptyRateIds = _unitOfWork.Articles.Get()
            .Where(article => article.Rate == null && !string.IsNullOrEmpty(article.Text))
            .Select(article => article.Id)
            .ToList();

        foreach (var articleId in articlesWithEmptyRateIds)
        {
            await RateArticleAsync(articleId);
        }
    }

    public async Task DeleteArticleAsync(Guid id)
    {

        var entity = await _unitOfWork.Articles.GetByIdAsync(id);

        if (entity != null)
        {
            _unitOfWork.Articles.Remove(entity);

            await _unitOfWork.Commit();
        }
        else
        {
            throw new ArgumentException("Article for removing doesn't exist", nameof(id));
        }
    }

    private async Task GetAllArticleDataFromRssAsync(Guid sourceId, string? sourceRssUrl)
    {
        if (!string.IsNullOrEmpty(sourceRssUrl))
        {
            var list = new List<ArticleDto>();

            using (var reader = XmlReader.Create(sourceRssUrl))
            {
                var feed = SyndicationFeed.Load(reader);

                foreach (var item in feed.Items)
                {
                    //should be checked for different rss sources
                    var articleDto = new ArticleDto()
                    {
                        Id = Guid.NewGuid(),
                        Title = item.Title.Text,
                        PublicationDate = item.PublishDate.UtcDateTime,
                        ShortSummary = item.Summary.Text,
                        Category = item.Categories.FirstOrDefault()?.Name,
                        SourceId = sourceId,
                        SourceUrl = item.Id
                    };
                    list.Add(articleDto);
                }
            }

            var oldArticleUrls = await _unitOfWork.Articles.Get()
                .Select(article => article.SourceUrl)
                .Distinct()
                .ToArrayAsync();

            var entities = list.Where(dto => !oldArticleUrls.Contains(dto.SourceUrl))
                .Select(dto => _mapper.Map<Article>(dto)).ToArray();

            await _unitOfWork.Articles.AddRangeAsync(entities);
            await _unitOfWork.Commit();

        }
    }

    private async Task AddArticleTextToArticleAsync(Guid articleId)
    {
        try
        {
            var article = await _unitOfWork.Articles.GetByIdAsync(articleId);

            if (article == null)
            {
                throw new ArgumentException($"Article with id: {articleId} doesn't exists",
                    nameof(articleId));
            }

            var articleSourceUrl = article.SourceUrl;

            var web = new HtmlWeb();
            var htmlDoc = web.Load(articleSourceUrl);
            var nodes =
                htmlDoc.DocumentNode.Descendants(0)
                    .Where(n => n.HasClass("news-text"));

            if (nodes.Any())
            {
                var articleText = nodes.FirstOrDefault()?
                    .ChildNodes
                    .Where(node => (node.Name.Equals("p") || node.Name.Equals("div") || node.Name.Equals("h2"))
                                   && !node.HasClass("news-reference")
                                   && !node.HasClass("news-banner")
                                   && !node.HasClass("news-widget")
                                   && !node.HasClass("news-vote")
                                   && node.Attributes["style"] == null)
                    .Select(node => node.OuterHtml)
                    .Aggregate((i, j) => i + Environment.NewLine + j);


                await _unitOfWork.Articles.UpdateArticleTextAsync(articleId, articleText);
                await _unitOfWork.Commit();
            }


        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private async Task RateArticleAsync(Guid articleId)
    {
        try
        {
            var article = await _unitOfWork.Articles.GetByIdAsync(articleId);

            if (article == null)
            {
                throw new ArgumentException($"Article with id: {articleId} doesn't exists",
                    nameof(articleId));
            }

            using (var client = new HttpClient())
            {
                var httpRequest = new HttpRequestMessage(HttpMethod.Post, 
                    new Uri(@"https://api.ispras.ru/texterra/v1/nlp?targetType=lemma&apikey=YOUR_KEY"));
                httpRequest.Headers.Add("Accept", "application/json");

                httpRequest.Content = JsonContent.Create(new[] {new TextRequestModel() { Text = article.Text}});

                var response = await client.SendAsync(httpRequest);
                var responseStr = await response.Content.ReadAsStreamAsync();

                using (var sr = new StreamReader(responseStr))
                {
                    var data = await sr.ReadToEndAsync();

                    var resp = JsonConvert.DeserializeObject<IsprassResponseObject[]>(data);
                }
            }


        }
        catch (Exception ex)
        {
            throw;
        }
    }

}