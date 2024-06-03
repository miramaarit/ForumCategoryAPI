using ForumCategoryAPI.DAL;
using ForumCategoryAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace ForumCategoryAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager;
        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
          
            return await _categoryManager.GetAllCategories();
        }
    }
}









