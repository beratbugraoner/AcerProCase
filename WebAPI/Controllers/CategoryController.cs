using Business.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _categoryService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetAll failed for category ", ex);
               
            }
            return BadRequest(new { Message = "GetAll failed for category" });

        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            try
            {
                var result = _categoryService.Add(category);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Add failed for category ", ex);
      
            }
            return BadRequest(new { Message = "Add failed for category" });
        }
        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            try
            {
                var result = _categoryService.Update(category);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Update failed for category ", ex);

                
            }
            return BadRequest(new { Message = "Update failed for category" });
        }

        [HttpDelete]
        public IActionResult Delete(Category category)
        {
            try
            {
                var result = _categoryService.Delete(category);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Delete failed for category ", ex);
              
            }
            return BadRequest(new { Message = "Delete failed for category" });
        }


    }
}
