using RecipeLibrary.DB_Logic;
using RecipeLibrary.Model;

namespace RecipeLibrary.Controller
{
    public class AddMeal
    {
        public  void AddNewMeal()
        {
            AddItems AI = new AddItems();

            //Get the meal name
            Console.WriteLine("What is the name of your meal");
            string MealName = Console.ReadLine();

            List<Meal> newMeal = new List<Meal>()
            {
                new Meal() {name = MealName}
            };

            //Get number of ingredients
            Console.WriteLine("How many ingredients are in the meal");
            var recipeNumber = Convert.ToInt32(Console.ReadLine());

            //Find index of MealName
            int mealIndex = newMeal.FindIndex(a => a.name.Equals($"{MealName}"));

            for (int i = 0; i < recipeNumber; i++)
            {
                Console.WriteLine($"What is ingredient {i + 1}");
                string x = Console.ReadLine();
                newMeal[mealIndex].ingredients.Add(new Ingredient {id = i+1, description = x });
            }

            foreach (var meal in newMeal)
            {
                AI.AddNewItems(meal); // Pass each Meal object individually
            }

            //Show the user what they saved
            Console.WriteLine($"\nYour Meal {newMeal[mealIndex].name} has been saved \nwith the ingredients : ");

            foreach (var item in newMeal[mealIndex].ingredients)
            {
                Console.WriteLine(item.description);
            }


        }
    }
}
