using AspBetSample.DataBase;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AspNetSample.Business.ServicesImplementations;

public class ArticleService : IArticleService
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    private readonly GoodNewsAggregatorContext _databaseContext;

    public ArticleService(GoodNewsAggregatorContext databaseContext,
        IMapper mapper, 
        IConfiguration configuration)
    {
        _databaseContext = databaseContext;
        _mapper = mapper;
        _configuration = configuration;
    }


    public async Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync(int pageNumber,
        int pageSize)
    {
        try
        {
            var myApiKey = _configuration.GetSection("UserSecrets")["MyApiKey"];
            var passwordSalt = _configuration["UserSecrets:PasswordSalt"];
            //_configuration.
            var list = await _databaseContext.Articles
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

    public async Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync()
    {
        var list = new List<ArticleDto>();
        return list;
    }

    public async Task<ArticleDto> GetArticleByIdAsync(Guid id)
    {
        var dto = new ArticleDto();
        //_articlesStorage.ArticlesList
        //.FirstOrDefault(articleDto => articleDto.Id.Equals(id));

        return dto;
    }
}