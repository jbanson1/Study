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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure primary keys and relationships using Fluent API
            modelBuilder.Entity<Meal>()
                .HasKey(m => m.id);  // Primary key for Meal

            modelBuilder.Entity<Ingredient>()
                .HasKey(i => i.id);  // Primary key for Ingredient

            modelBuilder.Entity<Meal>()
                .HasMany(m => m.ingredients)
                .WithRequired(i => i.Meal)
                .HasForeignKey(i => i.meal_id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
