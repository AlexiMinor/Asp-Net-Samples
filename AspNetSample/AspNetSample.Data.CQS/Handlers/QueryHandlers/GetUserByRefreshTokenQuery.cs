using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Handlers.QueryHandlers;

public class GetUserByRefreshTokenQuery: IRequest<UserDto?>
{
    public Guid RefreshToken { get; set; }
}