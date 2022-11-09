using AspBetSample.DataBase;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.CQS.Handlers.QueryHandlers;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.CQS.Queries;

public class GetAllArticlesWithoutTextQueryHandler : IRequestHandler<GetAllArticlesWithoutTextIdsQuery, Guid[]?>
{
    private readonly GoodNewsAggregatorContext _context;
    private readonly IMapper _mapper;

    public GetAllArticlesWithoutTextQueryHandler(GoodNewsAggregatorContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Guid[]?> Handle(GetAllArticlesWithoutTextIdsQuery request, 
        CancellationToken cancellationToken)
    {
        var articlesWithEmptyTextIds = await _context.Articles.AsNoTracking()
            .Where(article => string.IsNullOrEmpty(article.Text))
            .Select(article => article.Id)
            .ToArrayAsync(cancellationToken);

        return articlesWithEmptyTextIds;
    }
}