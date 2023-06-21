using CategoryCrud.Model;
using Microsoft.AspNetCore.Mvc;

namespace CategoryCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService categoryService;
        public CategoryController(CategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(categoryService.GetAllCategories());
        }
    }
}
