using RecipeLibrary.Db_Context;
using RecipeLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.DB_Logic
{
    public class ReadItems
    {
        public Meal Get(int id)
        {
            var Context = new ApplicationDbContext();
            var result = Context.meals.FirstOrDefault(x => x.id == id);

            return (Meal)result;
        }

        public List<Ingredient> GetIngredients(int id) 
        {
            var context = new ApplicationDbContext();
            var result = context.ingredients.Where(x => x.meal_id == id).ToList();

            return result;
        }

        public List<Meal> GetAll()
        {
            var Context = new ApplicationDbContext();

            var result = Context.meals.ToList();

            return result;
        }
    }
}
