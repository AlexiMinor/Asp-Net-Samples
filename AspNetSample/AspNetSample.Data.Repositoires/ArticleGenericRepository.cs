using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Data.Abstractions.Repositories;

namespace AspNetSample.Data.Repositories;

public class ArticleGenericRepository : Repository<Article>, IAdditionalArticleRepository
{
    public ArticleGenericRepository(GoodNewsAggregatorContext database) 
        : base(database)
    {
    }

    public void DoCustomMethod()
    {
        throw new NotImplementedException();
    }
}