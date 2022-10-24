﻿using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Core.Abstractions;

public interface IArticleService
{
    Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync
        (int pageNumber, int pageSize);

    Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync();
    
    Task<List<ArticleDto>> GetArticlesByNameAndSourcesAsync(string? name, Guid? category);

    Task<ArticleDto> GetArticleByIdAsync(Guid id);

    Task<int> CreateArticleAsync(ArticleDto dto);

    Task<int> UpdateArticleAsync(Guid id, ArticleDto? patchList);

    Task GetAllArticleDataFromRssAsync(Guid sourceId, string? sourceRssUrl);
    
    Task AddArticleTextToArticlesAsync();

    Task DeleteArticleAsync(Guid id);
}