using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeLibrary.Model
{
    public class Meal
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description_of_meal { get; set; }
        public List<Ingredient> ingredients { get; set; }

        public Meal()
        {
            ingredients = new List<Ingredient>();
        }
    }

    public class Ingredient
    {
        [Key]
        public int id { get; set; }
        public string description { get; set; }
        public int meal_id { get; set; }
        [ForeignKey("meal_id")]
        public Meal Meal { get; set; }
    }
}
