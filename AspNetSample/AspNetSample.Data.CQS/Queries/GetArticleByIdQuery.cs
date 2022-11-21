using AspBetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Queries;

public class GetArticleByIdQuery : IRequest<Article?>
{
    public Guid Id { get; set; }
}