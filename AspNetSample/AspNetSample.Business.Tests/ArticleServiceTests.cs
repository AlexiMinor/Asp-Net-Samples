using System.Linq.Expressions;
using AspBetSample.DataBase.Entities;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AspNetSample.Data.CQS.Commands;
using AspNetSample.Data.CQS.Queries;
using AutoMapper;
using HtmlAgilityPack;
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
        public readonly Mock<HtmlWeb> _htmlWebMock = new Mock<HtmlWeb>();

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


        //[Fact]
        //public void AddArticleTextToArticleAsync_WithCorrectId_AddCorrectData()
        //{
        //    var article = new Article(){SourceUrl = "123"};
        //    _mediatorMock.Setup(m => m.Send(It.IsAny<GetArticleByIdQuery>(), It.IsAny<CancellationToken>()))
        //        .ReturnsAsync(article);
        //    _htmlWebMock.Setup(web => web.Load(It.IsAny<string>())).Returns(new HtmlDocument()
        //    {
        //        DocumentNode = {  }
        //    })

        //}

        [Fact]
        public async Task GetArticleByIdAsync_WithCorrectId_ReturnArticle()
        {
            var guid = Guid.NewGuid();
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetArticleByIdQuery>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Article() { Id = guid });
            _mapperMock.Setup(m => m.Map<ArticleDto>(It.IsAny<Article>()))
                .Returns(new ArticleDto { Id = guid });
            var service = GetMockedArticleService();

            var data = await service.GetArticleByIdAsync(guid);

            Assert.NotNull(data);
            Assert.Equal(guid,data.Id);
        }

        [Fact]
        public async Task GetArticleByIdAsync_WithIncorrectId_ReturnNull()
        {
            var guid = Guid.NewGuid();
            Article? article = null;
            _mediatorMock.Setup(mediator => mediator.Send(It.IsAny<GetArticleByIdQuery>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(article);
            var service = GetMockedArticleService();

            var data = await service.GetArticleByIdAsync(guid);

            Assert.Null(data);
        }
    }
}