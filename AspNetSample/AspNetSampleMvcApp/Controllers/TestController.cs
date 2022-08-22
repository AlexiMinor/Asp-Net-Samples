using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers;


public class TestController : Controller
{
    //[NonAction] //Don't needed in real app with clean code
    public IActionResult Index()
    {
        var cat = new 
        {
            Name = "Vasily",
            Age = 15,
        };
        return Ok(cat);
    }

    [ActionName("Do")]
    public string DoSpecificThing()
    {
        return "cat Vasiliy";
    }

}