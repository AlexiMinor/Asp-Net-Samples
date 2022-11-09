using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Handlers.QueryHandlers;

public class GetArticleByIdQuery: IRequest<ArticleDto?>
{
    public Guid Id { get; set; }
}