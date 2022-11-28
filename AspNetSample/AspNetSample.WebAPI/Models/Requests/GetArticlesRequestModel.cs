namespace AspNetSample.WebAPI.Models.Requests;

public class GetArticlesRequestModel
{
    public string? Name { get; set; }
    public Guid? SourceId { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}