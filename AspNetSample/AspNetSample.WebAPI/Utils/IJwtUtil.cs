using AspNetSample.Core.DataTransferObjects;
using AspNetSample.WebAPI.Models.Responses;

namespace AspNetSample.WebAPI.Utils;

public interface IJwtUtil
{
    Task<TokenResponse> GenerateTokenAsync(UserDto dto);
    Task RemoveRefreshTokenAsync(Guid requestRefreshToken);
}