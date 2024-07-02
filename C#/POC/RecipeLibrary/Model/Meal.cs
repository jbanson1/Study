using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.Model
{
    public class Meal
    {
        public string name { get; set; }

        public List<string> ingredients { get; set; }

        public Meal()
        {
            ingredients = new List<string>();
        }
    }

    public class ingredients
    {
        public string description { get; set; }
    }
}
