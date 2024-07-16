using RecipeLibrary.DB_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.Controller
{
    public class DeleteMeal
    {
        public int deletemeal(int x)
        {
            Console.WriteLine("What would you like to delete");

            DeleteItems deleteItems = new DeleteItems();

            deleteItems.DeleteAnItem(x);

            Console.WriteLine("Would you like to go back to the menu");
            var storeMoreMeals = Console.ReadLine().ToLower();
            return storeMoreMeals == "yes" ? 1 : 0;
        }
    }
}
