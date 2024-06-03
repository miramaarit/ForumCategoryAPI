using ForumCategoryAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace ForumCategoryAPI.DAL
{
    public class CategoryManager
    {
        private readonly FilmFunForum2Context _context;

        public CategoryManager(FilmFunForum2Context context)
        {
            _context = context;
            
           
        }
        public  IEnumerable<Category> Categories { get; set; }

        public  async Task <IEnumerable<Category>> GetAllCategories()
        {
            if (Categories == null || Categories.Any())
            {
                Categories = await _context.Category.ToListAsync();
            }
            return Categories;
        }
    }
}
