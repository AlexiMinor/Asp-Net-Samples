using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Handlers.QueryHandlers;

public class GetAllArticlesWithoutTextIdsQuery: IRequest<Guid[]?>
{
    
}