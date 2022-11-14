using System.Linq.Expressions;
using AspBetSample.DataBase.Entities;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Moq;

namespace AspNetSample.Business.Tests
{
    public class UserServiceTests
    {
        public readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();
        public readonly Mock<IConfiguration> _configurationMock = new Mock<IConfiguration>();
        public readonly Mock<IUnitOfWork> _uowMock = new Mock<IUnitOfWork>();
        public readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();

        private UserService GetMockedUserService()
        {
            var userService = new UserService(_mapperMock.Object,
                _configurationMock.Object,
                _uowMock.Object,
                _mediatorMock.Object);

            return userService;
        }

        [Fact]
        public void GetUserByEmailAsync_WithCorrectEmail_ReturnUser()
        {
            //arrange
            var email = "test@email.com";
            var listUsers = new List<User>()
            {
                new()
            };
            var dto = new UserDto()
            {
                Id = Guid.NewGuid(),
                Email = email,
                RoleName = "User",
                RoleId = Guid.NewGuid(),
                PasswordHash = "abc"
            };

            _uowMock.Setup(x => x.Users
                    .FindBy(
                        It.IsAny<Expression<Func<User, bool>>>(),
                        It.IsAny<Expression<Func<User, object>>[]>()))
                .Returns(listUsers.AsQueryable());
            
            _mapperMock.Setup(mapper => 
                    mapper.Map<UserDto>(It.IsAny<User>()))
                .Returns(dto);

            //action
            var userService = GetMockedUserService();
            var data = userService.GetUserByEmailAsync(email);

            //asserts
            Assert.NotNull(data);
            Assert.Equal(email, data.Email);
        }

        [Fact]
        public void GetUserByEmailAsync_WitEmptyEmail_ReturnNull()
        {
            //arrange
            var email = "";
            var listUsers = new List<User>();
            _uowMock.Setup(x => x.Users
                    .FindBy(
                        It.IsAny<Expression<Func<User, bool>>>(),
                        It.IsAny<Expression<Func<User, object>>[]>()))
                .Returns(listUsers.AsQueryable());

        
            //action
            var userService = GetMockedUserService();
            var data = userService.GetUserByEmailAsync(email);

            //asserts
            Assert.Null(data);
        }

        [Fact]
        public void GetUserByEmailAsync_WitIncorrectEmail_ReturnNull()
        {
            //arrange
            var email = "123@mail.ru";
            var listUsers = new List<User>();
            _uowMock.Setup(x => x.Users
                    .FindBy(
                        It.IsAny<Expression<Func<User, bool>>>(),
                        It.IsAny<Expression<Func<User, object>>[]>()))
                .Returns(listUsers.AsQueryable());


            //action
            var userService = GetMockedUserService();
            var data = userService.GetUserByEmailAsync(email);

            //asserts
            Assert.Null(data);
        }
    }
}