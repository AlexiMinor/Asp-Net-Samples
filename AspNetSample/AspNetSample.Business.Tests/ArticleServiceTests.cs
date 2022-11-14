using System.Linq.Expressions;
using AspBetSample.DataBase.Entities;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AspNetSample.Data.CQS.Commands;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Moq;

namespace AspNetSample.Business.Tests
{
    public class ArticleServiceTests
    {
        public readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();
        public readonly Mock<IConfiguration> _configurationMock = new Mock<IConfiguration>();
        public readonly Mock<IUnitOfWork> _uowMock = new Mock<IUnitOfWork>();
        public readonly Mock<IMediator> _mediatorMock = new Mock<IMediator>();

        private ArticleService GetMockedArticleService()
        {
            var articleService = new ArticleService(_mapperMock.Object,
                _configurationMock.Object,
                _uowMock.Object,
                _mediatorMock.Object);

            return articleService;
        }

        [Fact]
        public void GetAllArticleDataFromRssAsync_WithCorrectData_RunSuccessfully()
        {
            //arrange
            var sourcesList = new List<Source>();
            _uowMock.Setup(x => x.Sources
                    .GetAllAsync())
                .ReturnsAsync(sourcesList);

            _mediatorMock.Setup(x => 
                    x.Send(It.IsAny<AddArticleDataFromRssFeedCommand>(), 
                        It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Unit());

            //action
            var articleService = GetMockedArticleService();
            var data = articleService.GetAllArticleDataFromRssAsync();

            //asserts
            Assert.NotNull(data);
        }

    
    }
}