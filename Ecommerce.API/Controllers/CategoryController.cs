using Ecommerce.Application.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [HttpGet("Categories")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _categoryServices.GetAllAsync();
            return Ok(result);
        }
    }
}
