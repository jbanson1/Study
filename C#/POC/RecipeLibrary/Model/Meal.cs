using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.Model
{
    public class Meal
    {
        public int id { get; set; }

        public string name { get; set; }

        public List<Ingredient> ingredients { get; set; }

        public Meal()
        {
            ingredients = new List<Ingredient>();
        }
    }

    public class Ingredient
    {
        public int id { get; set; }
        public string description { get; set; }
        public int meal_id { get; set; }
    }
}
