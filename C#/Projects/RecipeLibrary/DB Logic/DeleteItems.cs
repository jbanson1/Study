using RecipeLibrary.Db_Context;
using RecipeLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.DB_Logic
{
    public class DeleteItems
    {
        public void DeleteAnItem(int x)
        {
            var context = new ApplicationDbContext();

            var meal = context.meals.FirstOrDefault(z => z.id == x);

            var ingredients = context.ingredients.Where(x => x == x).ToList();

            context.meals.Remove(meal);

            foreach(var y in ingredients) 
            {
                context.ingredients.Remove(y);
            }
            context.SaveChanges();
        }
    }
}
