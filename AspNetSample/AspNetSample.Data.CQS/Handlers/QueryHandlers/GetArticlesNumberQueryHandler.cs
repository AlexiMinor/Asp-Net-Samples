using AspBetSample.DataBase;
using AspNetSample.Data.CQS.Queries;
using MediatR;

namespace AspNetSample.Data.CQS.Handlers.QueryHandlers;

public class GetArticlesNumberQueryHandler : IRequestHandler<GetArticlesNumberQuery, int>
{
    private readonly GoodNewsAggregatorContext _context;

    public GetArticlesNumberQueryHandler(GoodNewsAggregatorContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(GetArticlesNumberQuery request, CancellationToken cancellationToken)
    {
        var articlesQueryable = _context.Articles.AsQueryable();
        if (request.SourceId.HasValue)
        {
            articlesQueryable = articlesQueryable
                .Where(article => article.SourceId.Equals(request.SourceId.Value));
        }
        if (request.MinRating.HasValue)
        {
            articlesQueryable = articlesQueryable
                .Where(article => article.Rate>=request.MinRating.Value);
        }

        return articlesQueryable.Count();


    }
}