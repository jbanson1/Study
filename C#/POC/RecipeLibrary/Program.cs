using RecipeLibrary.Controller;
using RecipeLibrary.Model;
using FluentValidation;

namespace RecipeLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 1;
            AddMeal addMeal = new AddMeal();
            DeleteMeal deleteMeal = new DeleteMeal();
            ViewRecipe  viewRecipe = new ViewRecipe();
            UpdateMeals updateMeals = new UpdateMeals();
            
            while (userChoice == 1)
            {
                Console.WriteLine("\nWelcome to recepie library Would you like to \n" +
                    " 1.View the all saved Meals available\n 2.View specific meal \n" +
                    " 3.Add a meal to the library \n 4.Delete a Meal \n 5.Update a meal");

                var userSelection = Convert.ToInt32(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        //Get everything
                        userChoice = viewRecipe.GetAll();
                        break;

                    case 2:
                        //Get one meal
                        viewRecipe.RetrieveList();
                        Console.WriteLine("What meal would you like to see");
                        var input = Convert.ToInt32(Console.ReadLine());
                        userChoice = viewRecipe.Get(input);
                        break;

                    case 3:
                        //Add a meal
                        userChoice = addMeal.AddNewMeal();
                        break;

                    case 4:
                        //Delete a meal
                        viewRecipe.RetrieveList();
                        Console.WriteLine("What meal would you like to delete");
                        input = Convert.ToInt32(Console.ReadLine());
                        userChoice = deleteMeal.deletemeal(input);
                        break;

                    case 5:
                        //Update a meal
                        userChoice = updateMeals.UpdateMeal();
                        break;

                    default:
                        Console.WriteLine($"What should I do with your input. Is {userSelection} one of the options behave yourself \n Lets try again");
                        break;
                }
            }
        }
    }
}