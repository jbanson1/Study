using RecipeLibrary.Db_Context;
using RecipeLibrary.Model;
using System.ComponentModel.Design;

namespace RecipeLibrary.DB_Logic
{
    public class AddItems
    {
        //Need to pass through ingredients as list
        // Make method asynchronus
        public void AddNewItems(Meal item1) 
        {
            var context = new ApplicationDbContext();

            //Try catch 
            try
            {
                context.meals.Add(item1);
                context.ingredients.AddRange(item1.ingredients);
            }
            catch(Exception )
            {
                Console.WriteLine("Couldnt save");
            }

            context.SaveChanges();
        }
    }
}
