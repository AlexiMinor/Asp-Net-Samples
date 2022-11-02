using AspBetSample.DataBase.Entities;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AspNetSample.Business.ServicesImplementations;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    private readonly IUnitOfWork _unitOfWork;


    public UserService(IMapper mapper,
        IConfiguration configuration,
        IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _configuration = configuration;
        _unitOfWork = unitOfWork;
    }


    public async Task<bool> IsUserExists(Guid userId)
    {
        return await _unitOfWork.Users.Get().AnyAsync(user => user.Id.Equals(userId));
    }

    public async Task<bool> IsUserExists(string email)
    {
        return await _unitOfWork.Users.Get().AnyAsync(user => user.Email.Equals(email));
    }

    public async Task<IEnumerable<UserDto>> GetAllUsers()
    {
        return (await _unitOfWork.Users.GetAllAsync()).Select(user => _mapper.Map<UserDto>(user)).ToArray();
    }

    public async Task<bool> CheckUserPassword(string email, string password)
    {
        var dbPasswordHash = (await _unitOfWork.Users
            .Get().FirstOrDefaultAsync(user => user.Email.Equals(email)))
            ?.PasswordHash;

        return
            dbPasswordHash != null
            && CreateMd5($"{password}.{_configuration["Secret:PasswordSalt"]}").Equals(dbPasswordHash);
    }

    public async Task<bool> CheckUserPassword(Guid userId, string password)
    {
        var dbPasswordHash = (await _unitOfWork.Users.GetByIdAsync(userId))?.PasswordHash;

        return 
            dbPasswordHash != null 
            && CreateMd5($"{password}.{_configuration["Secret:PasswordSalt"]}").Equals(dbPasswordHash);
    }

    public async Task<int> RegisterUser(UserDto dto, string password)
    {
        var user = _mapper.Map<User>(dto);

        user.PasswordHash = CreateMd5($"{password}.{_configuration["Secret:PasswordSalt"]}");

        await _unitOfWork.Users.AddAsync(user);
        return await _unitOfWork.Commit();
    }


    public async Task<UserDto?> GetUserByEmailAsync(string email)
    {
        var user = await _unitOfWork.Users
            .FindBy(us => us.Email.Equals(email),
                us => us.Role)
            .FirstOrDefaultAsync();

        return 
            user != null ?
            _mapper.Map<UserDto>(user) : 
            null;
    }

    private string CreateMd5(string password)
    {
        var passwordSalt = _configuration["UserSecrets:PasswordSalt"];

        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(password + passwordSalt);
            var hashBytes = md5.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes);
        }
    }



}