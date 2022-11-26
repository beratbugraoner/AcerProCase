using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly ILogger<AuthController> _logger;

        public NewsController(INewsService newsService, ILogger<AuthController> logger)
        {
            _newsService = newsService;
            _logger = logger;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _newsService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News GetAll failed.", ex);
            }
            return BadRequest(new { Message = "News GetAll failed." });

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _newsService.GetById(id);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News GetAll failed.", ex);
                
            }
            return BadRequest(new { Message = "News GetById failed." });

        }
        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            try
            {
                var result = _newsService.GetAllNewsByCategoryId(categoryId);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News GetByCategory failed.", ex);
               
            }
            return BadRequest(new { Message = "News GetByCategory failed." });
        }

        [HttpGet("getactivesall")]
        public IActionResult GetAllActives()
        {
            try
            {
                var result = _newsService.GetAllActiveNews();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News GetAllActives failed.", ex);
             
            }
            return BadRequest(new { Message = "News GetAllActives failed." });


        }


        [HttpPost("add")]
        public IActionResult Add(News news)
        {
            try
            {
                var result = _newsService.Add(news);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News Add failed.", ex);
                
            }
            return BadRequest(new { Message = "News Add failed." });
        }
        [HttpPost("update")]
        public IActionResult Update(News news)
        {
            try
            {
                var result = _newsService.Update(news);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News Update failed.", ex);
          
            }
            return BadRequest(new { Message = "News Update failed." });

        }

        [HttpDelete]
        public IActionResult Delete(News news)
        {
            try
            {
                var result = _newsService.Delete(news);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News Delete failed.", ex);
                
            }
            return BadRequest(new { Message = "News Delete failed." });
        }

        [HttpPost("changestatustrue")]
        public IActionResult ChangeStatusTrue(News news)
        {
            try
            {
                var result = _newsService.Delete(news);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News ChangeStatusTrue failed.", ex);
             
            }
            return BadRequest(new { Message = "News ChangeStatusTrue failed." });
        }
        [HttpPost("changestatusfalse")]
        public IActionResult ChangeStatusalse(News news)
        {
            try
            {
                var result = _newsService.ChangeTheStatusFalse(news);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("News ChangeStatusFalse failed.", ex);
               
            }
            return BadRequest(new { Message = "News ChangeStatusFalse failed." });
        }

    }
}
