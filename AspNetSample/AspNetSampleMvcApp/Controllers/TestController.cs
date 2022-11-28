using System.Text;
using AspNetSampleMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers;


public class TestController : Controller
{
    private static List<CalendarEventModel> models =
        new List<CalendarEventModel>()
        {
            new CalendarEventModel()
            {
                Name = "Event #1",
                StartDate = new DateTime(2022, 11, 28, 12, 0, 0),
                EndDate = new DateTime(2022, 11, 28, 12, 30, 0),
                ShortDescription = "Event #1 some long description"

            },
            new CalendarEventModel()
            {
                Name = "Event #2",
                StartDate = new DateTime(2022, 11, 29, 12, 0, 0),
                EndDate = new DateTime(2022, 11, 29, 12, 30, 0),
                ShortDescription = "Event #2 some long description"
            },
            new CalendarEventModel()
            {
                Name = "Event #3",
                StartDate = new DateTime(2022, 11, 30, 12, 0, 0),
                EndDate = new DateTime(2022, 11, 30, 12, 30, 0),
                ShortDescription = "Event #3 some long description",
                Location = "https://zoom.us/test"
            },
        };

    public IActionResult Calendar()
    {
        var model = models;
        return View(model);
    }

    public IActionResult Calendar2()
    {
        var model = models;
        return View(model);
    }
}