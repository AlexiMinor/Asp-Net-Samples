namespace AspNetSample.WebAPI.Models.Requests;

public class GetArticlesCountRequestModel
{
    public Guid? SourceId { get; set; }
    public float? MinRating { get; set; }
}