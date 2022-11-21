using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.CQS.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.CQS.Handlers.QueryHandlers;

public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery, Article?>
{
    private readonly GoodNewsAggregatorContext _context;

    public GetArticleByIdQueryHandler(GoodNewsAggregatorContext context)
    {
        _context = context;
    }

    public async Task<Article?> Handle(GetArticleByIdQuery request,
        CancellationToken cancellationToken)
    {
        var article = await _context.Articles
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id.Equals(request.Id), cancellationToken);

        return article;
    }
}