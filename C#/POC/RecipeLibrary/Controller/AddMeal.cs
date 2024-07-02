using RecipeLibrary.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.Controller
{
    public class AddMeal
    {
        public void AddNewMeal()
        {
            Console.WriteLine("What is the name of your meal");
            string MealName = Console.ReadLine();
            
            List<Meal> newMeal = new List<Meal>()
            { 
                new Meal() {name = MealName}
            };

            Console.WriteLine("How many ingredients are in the meal");
            var recipeNumber = Convert.ToInt32(Console.ReadLine());

            //Find index of MealName
            int mealIndex = newMeal.FindIndex(a => a.name.Equals($"{MealName}"));

            for (int i = 0; i < recipeNumber; i++)
            {
                Console.WriteLine($"What is ingredient {i + 1}");
                string x = Console.ReadLine();
                newMeal[mealIndex].ingredients.Add(x);
            }
        }
    }
}
