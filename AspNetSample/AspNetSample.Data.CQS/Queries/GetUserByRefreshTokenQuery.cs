using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Queries;

public class GetUserByRefreshTokenQuery : IRequest<UserDto?>
{
    public Guid RefreshToken { get; set; }
}