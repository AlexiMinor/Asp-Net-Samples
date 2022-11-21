using AspBetSample.DataBase.Entities;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;
using Moq;

namespace AspNetSample.Business.Tests
{
    public class SpecificServiceTests
    {
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();
      
        private SpecificService GetMockedSpecificService()
        {
            var specificService = new SpecificService(_mapperMock.Object);

            return specificService;
        }

        [Fact]
        public void UpdateArticle_WithCorrectData_ReturnCorrectDto()
        {
            //assume
            var id = Guid.NewGuid();
            var dto = new ArticleDto()
            {
                Id = id,
                Text = "abc",
                Rate = null
            };
            var ent = new Article()
            {
                Id = id,
                Text = "abc",
                Rate = null
            };
            var newText = "bca";
            var newRate = 1;
            _mapperMock.Setup(mapper => mapper.Map<Article>(It.IsAny<ArticleDto>()))
                .Returns(ent);
            var service = GetMockedSpecificService();
            
            //act
            var result = service.UpdateArticle(dto, newText, newRate);

            //assert
            Assert.NotNull(result);
            Assert.Equal(newText, result.Text);
            Assert.Equal(newRate, result.Rate);

        }
    }
}