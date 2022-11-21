using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Queries;

public class GetAllArticlesWithoutTextIdsQuery : IRequest<Guid[]?>
{

}