using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers
{
    [NonController] //Don't needed in real app with clean code
    public class BaseController : Controller
    {
        public IActionResult Context()
        {
            
            return Ok();
        }
    }
}
