namespace AspNetSampleMvcApp.Models;

public class CalendarEventModel
{
    public string Name { get; set; }
    public string? ShortDescription { get; set; }
    public string? Location { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}