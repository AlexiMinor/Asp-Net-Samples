using AspNetSampleMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AspNetSampleMvcApp.Filters;

namespace AspNetSampleMvcApp.Controllers
{
    //[CustomActionFilter]
    [InternetExplorerBlockerFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AddDataToResponseHeaderFilter]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Privacy")]
        [HappyExceptionFilter("You'll read privacy policy in future.")]
        public IActionResult Privacy()
        {
            return View();
        }

        public int About()
        {
            var str = "Test Asp.Net MVC Application with string response!";
            var a = 156;

            return a;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}