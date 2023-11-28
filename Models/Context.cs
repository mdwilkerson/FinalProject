using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Recipe> Recipes {get; set;}
        public DbSet<Category> Categories {get; set;} 
    }
}