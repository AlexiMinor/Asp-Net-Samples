﻿using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AspNetSample.Data.Abstractions.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
            var passwordSalt = _configuration["UserSecrets:PasswordSalt"];
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

    public async Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync()
    {
        var list = new List<ArticleDto>();
        return list;
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

    public async Task<int> PatchAsync(Guid id, List<PatchModel> patchList)
    {
        await _unitOfWork.Articles.PatchAsync(id, patchList);
        return await _unitOfWork.Commit();
    }

    public async Task Do()
    {
        await _unitOfWork.Articles.AddAsync(new Article());
        await _unitOfWork.Sources.AddAsync(new Source());
        
        await _unitOfWork.Commit();
    }
}