using AspNetSample.Core.DataTransferObjects;
using AspNetSample.WebAPI.Models.Responses;

namespace AspNetSample.WebAPI.Utils;

public interface IJwtUtil
{
    TokenResponse GenerateToken(UserDto dto);
}