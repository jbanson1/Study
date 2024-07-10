using RecipeLibrary.Model;
using System.Data.Entity;

namespace RecipeLibrary.Db_Context
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<Meal>meals { get; set; }
        public DbSet<Ingredient>ingredients { get; set; }
    }
}
