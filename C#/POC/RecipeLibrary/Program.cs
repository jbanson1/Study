using RecipeLibrary.Controller;
using RecipeLibrary.Model;
namespace RecipeLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddMeal addMeal = new AddMeal();
            DeleteMeal deleteMeal = new DeleteMeal();
            ViewRecipe  viewRecipe = new ViewRecipe();

            Console.WriteLine("Hello welcome to recepie library Would you like to \n 1.View the saved Meals available \n 2.Add a meal to the library \n 3.Delete a Meal");

            int userSelection = Convert.ToInt32(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:

                        break;

                    case 2:
                        addMeal.AddNewMeal();
                        break;

                    case 3:

                        break;

                    default:
                        Console.WriteLine("What should I do with your input");
                        break;
                }
        }
    }
}