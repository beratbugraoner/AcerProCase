using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        
        public NewsController(INewsService newsService)
        {
           _newsService = newsService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var result = _newsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _newsService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _newsService.GetAllNewsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getactivesall")]
        public IActionResult GetAllActives()
        {
            var result = _newsService.GetAllActiveNews();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(News news)
        {
            var result = _newsService.Add(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(News news)
        {
            var result = _newsService.Update(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(News news)
        {
            var result = _newsService.Delete(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("changestatustrue")]
        public IActionResult ChangeStatusTrue(News news)
        {
            var result = _newsService.ChangeTheStatusTrue(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("changestatusfalse")]
        public IActionResult ChangeStatusalse(News news)
        {
            var result = _newsService.ChangeTheStatusFalse(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
