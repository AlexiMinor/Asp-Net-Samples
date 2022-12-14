using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Core.Abstractions;

public interface IArticleService
{
    Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync
        (int pageNumber, int pageSize);

    Task AggregateArticlesFromExternalSourcesAsync();
    
    //Task<List<ArticleDto>> GetArticlesByNameAndSourcesAsync(string? name, Guid? category);

    Task<ArticleDto> GetArticleByIdAsync(Guid id);

    Task<int> CreateArticleAsync(ArticleDto dto);

    Task<int> UpdateArticleAsync(Guid id, ArticleDto? patchList);

    Task GetAllArticleDataFromRssAsync();
    
    Task AddArticleTextToArticlesAsync();

    Task DeleteArticleAsync(Guid id);

    Task AddRateToArticlesAsync();

    Task<IEnumerable<ArticleDto>> GetArticlesByNameAndSourcesAsync(string? modelName, 
        Guid? modelSourceId, 
        int pageSize,
        int pageNumber);

    Task<int> GetNumberAsync(Guid? sourceId, float? minRating);
}