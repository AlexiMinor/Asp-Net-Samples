using MediatR;

namespace AspNetSample.Data.CQS.Queries;

public class GetArticlesNumberQuery : IRequest<int>
{
    public Guid? SourceId { get; set; }
    public float? MinRating { get; set; }
}