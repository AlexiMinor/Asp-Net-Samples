using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.WebAPI.Models.Requests;
using AspNetSample.WebAPI.Models.Responses;
using AutoMapper;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSample.WebAPI.Controllers
{
    /// <summary>
    /// Controller for work with articles
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;
        private readonly ISourceService _sourceService;
        private readonly IMapper _mapper;

        public ArticlesController(IArticleService articleService,
            ISourceService sourceService,
            IMapper mapper)
        {
            _articleService = articleService;
            _sourceService = sourceService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get article from storage with specified id
        /// </summary>
        /// <param name="id">Id of article</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Authorize]
        [ProducesResponseType(typeof(ArticleDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetArticleById(Guid id)
        {
            var article = await _articleService.GetArticleByIdAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        /// <summary>
        /// Get articles by article name substring and source id
        /// </summary>
        /// <param name="model">Contains article name substring and source id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetArticles([FromQuery] GetArticlesRequestModel? model)
        {
            if (model!= null)
            {
                if (model.PageSize == 0)
                {
                    model.PageSize = 5;
                }
                var articles = await _articleService
                    .GetArticlesByNameAndSourcesAsync(model?.Name, model?.SourceId, model.PageSize, model.PageNumber);

                //var jobId = BackgroundJob.Enqueue(() => Console.WriteLine(HttpContext.Request.Method));
                //var jobId2 = BackgroundJob.Schedule(() => Console.WriteLine(HttpContext.Request.Method), 
                //    TimeSpan.FromMinutes(1));


                return Ok(articles.ToList());
            }
            return BadRequest();
        }



      

        [HttpPut("{id}")]
        public IActionResult UpdateArticles(Guid id, [FromBody] AddOrUpdateArticleRequestModel? model)
        {
            if (model != null)
            {
                //var oldValue = Articles.FirstOrDefault(dto => dto.Id.Equals(id));

                //if (oldValue == null)
                //{
                //    return NotFound();
                //}

                //var newValue = new ArticleDto()
                //{
                //    Id = oldValue.Id,
                //    PublicationDate = DateTime.Now,
                //    Title = model.Title,
                //    Text = model.Text,
                //    Category = model.Category,
                //    ShortSummary = model.ShortSummary
                //};

                //Articles.Remove(oldValue);
                //Articles.Add(newValue);

                return Ok();
            }

            return BadRequest();
        }


        [HttpPatch("{id}")]
        public IActionResult UpdateArticles(Guid id, [FromBody] PatchRequestModel? model)
        {
            //if (model != null)
            //{
            //    var oldValue = Articles.FirstOrDefault(dto => dto.Id.Equals(id));

            //    if (oldValue == null)
            //    {
            //        return NotFound();
            //    }

            //    //todo add patch implementation(change only fields from request

            //    return Ok();
            //}

            return BadRequest();
        }

        /// <summary>
        /// Delete Article
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Nullable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteArticle(Guid id)
        {
            try
            {
                await _articleService.DeleteArticleAsync(id);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ErrorModel { Message = ex.Message });
            }
        }
    }
}
