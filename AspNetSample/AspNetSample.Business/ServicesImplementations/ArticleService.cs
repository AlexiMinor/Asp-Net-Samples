using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Business.ServicesImplementations;

public class ArticleService : IArticleService
{
    private readonly ArticlesStorage _articlesStorage;
    public ArticleService(ArticlesStorage articlesStorage)
    {
        _articlesStorage = articlesStorage;
    }

    public async Task<List<ArticleDto>> GetArticlesByPageNumberAndPageSizeAsync(int pageNumber, int pageSize)
    {
        List<ArticleDto> list;
        //using (var db = new Context)
        //{
        //    list = db.Articles.AsNoTracking.Skip(page * _pageSize)
        //        .Take(_pageSize)
        //        .Select(art => new ArticleModel()
        //        {
        //            some data here
        //        })
        //        .ToList();
        //}
        list = _articlesStorage.ArticlesList
            .Skip(pageNumber * pageSize)
            .Take(pageSize)
            .ToList();
        return list;
    }

    public async Task<List<ArticleDto>> GetNewArticlesFromExternalSourcesAsync()
    {
        var list = new List<ArticleDto>();
        return list;
    }
}