using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Data.CQS.Handlers.CommandHandlers;
using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Linq.Expressions;
using AspNetSample.Data.CQS.Commands;

namespace AspNetSample.Data.CQS.Tests
{
    public class UpdateArticleTextCommandHandlerTests
    {
        public readonly Mock<GoodNewsAggregatorContext> ContextMock 
            = new Mock<GoodNewsAggregatorContext>();

        //private UpdateArticleTextCommandHandler GetMockedUpdateArticleTextCommandHandler()
        //{
        //    var commandHandler = new UpdateArticleTextCommandHandler(ContextMock.Object);

        //    return commandHandler;
        //}

        //[Fact]
        //public async Task Handle_WithCorrectIdAndText_UpdateArticleSuccessfully()
        //{
        //    var id = Guid.NewGuid();
            
        //    var articles = new List<Article>()
        //    {
        //        new Article { Id = id },
        //        new Article { Id = Guid.NewGuid()},
        //        new Article { Id = Guid.NewGuid()},
        //};
        //    var command = new UpdateArticleTextCommand()
        //    {
        //        Id = id,
        //        Text = "abc"
        //    };

        //    ContextMock.SetupGet(x => x.Articles)
        //        .Returns((DbSet<Article>)articles.AsQueryable());

        //    //ContextMock
        //    //    .Setup(context => 
        //    //        context.Articles.FirstOrDefaultAsync(It.IsAny<Expression<Func<Article, bool>>>(),
        //    //        It.IsAny<CancellationToken>()))
        //    //    .ReturnsAsync(article);
        //    ContextMock.Setup(context => context.SaveChangesAsync(It.IsAny<CancellationToken>()))
        //        .ReturnsAsync(1);
        //    var ch = GetMockedUpdateArticleTextCommandHandler();
            
        //    await ch.Handle(command, new CancellationToken());

        //    Assert.Equal(command.Text,articles.FirstOrDefault().Text);
        //}

        //[Fact]
        //public void Handle_WithIncorrectIdAndCorrectText_ReturnException()
        //{

        //}

        //[Fact]
        //public void Handle_WithCorrectIdAndIncorrectText_ReturnException()
        //{

        //}
    }
}