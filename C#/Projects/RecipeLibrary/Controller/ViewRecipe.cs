using RecipeLibrary.DB_Logic;
using RecipeLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.Controller
{
    public class ViewRecipe
    {
        public int Get(int id)
        {
            ReadItems readItems = new ReadItems();

            Meal mealitem = readItems.Get(id);
            var mealIngredients = readItems.GetIngredients(id);

            Console.WriteLine($"\n{mealitem.name}");
            foreach (var item in mealIngredients)
            {
                Console.WriteLine(item.description);
                
            }


            Console.WriteLine("Would you like to go back to the menu");
            var storeMoreMeals = Console.ReadLine().ToLower();
            return storeMoreMeals == "yes" ? 1 : 0;
        }

        public int GetAll()
        {
            ReadItems readItems = new ReadItems();
            var meals = readItems.GetAll();

            if (meals.Count > 0)
            {
                foreach (var meal in meals)
                {
                    Console.WriteLine($"{meal.id} : {meal.name}");
                }
            }
            else
            {
                Console.WriteLine("No meals found.");
            }


            Console.WriteLine("Would you like to go back to the menu");
            var storeMoreMeals = Console.ReadLine().ToLower();
            return storeMoreMeals == "yes" ? 1 : 0;
        }

        public void RetrieveList()
        {
            ReadItems readItems = new ReadItems();
            var meals = readItems.GetAll();

            if (meals.Count > 0)
            {
                foreach (var meal in meals)
                {
                    Console.WriteLine($"{meal.id} : {meal.name}");
                }
            }
            else
            {
                Console.WriteLine("No meals found.");
            }
        }
    }
}
