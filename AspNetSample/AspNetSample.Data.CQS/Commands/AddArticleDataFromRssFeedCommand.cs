using AspNetSample.Core.DataTransferObjects;
using MediatR;

namespace AspNetSample.Data.CQS.Commands;

public class AddArticleDataFromRssFeedCommand : IRequest
{
    public IEnumerable<ArticleDto>? Articles;
}