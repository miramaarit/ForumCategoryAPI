using ForumCategoryAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace ForumCategoryAPI.DAL
{
   
        
        public class FilmFunForum2Context : DbContext
        {
            public FilmFunForum2Context(DbContextOptions<FilmFunForum2Context> options)
            : base(options)
            {
            }
            public DbSet<Category> Category { get; set; } = default!;
      
        }

     

    
}
