using AspNetSample.Core.Abstractions;
using AspNetSample.WebAPI.Models.Requests;
using AspNetSample.WebAPI.Models.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleResourseInitializer : ControllerBase
    {

        private readonly IArticleService _articleService;
        private readonly ISourceService _sourceService;
        private readonly IMapper _mapper;

        public ArticleResourseInitializer(IArticleService articleService, 
            ISourceService sourceService, 
            IMapper mapper)
        {
            _articleService = articleService;
            _sourceService = sourceService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddArticles()
        {
            try
            {
                var sources = await _sourceService.GetSourcesAsync();
                foreach (var source in sources)
                {
                    await _articleService.GetAllArticleDataFromRssAsync(source.Id, source.RssUrl);
                    await _articleService.AddArticleTextToArticlesAsync();

                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorModel() { Message = ex.Message });
            }
        }
    }
}
