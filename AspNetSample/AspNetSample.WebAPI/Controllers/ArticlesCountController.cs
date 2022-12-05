using AspNetSample.Core.Abstractions;
using AspNetSample.WebAPI.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesCountController : ControllerBase
    {

        private readonly IArticleService _articleService;

        public ArticlesCountController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticlesCount([FromQuery] GetArticlesCountRequestModel? model)
        {
            if (model != null)
            {
                var articlesNumber = await _articleService
                    .GetNumberAsync(model.SourceId, model.MinRating);

                return Ok(articlesNumber);
            }
            return BadRequest();
        }
    }
}
