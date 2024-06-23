using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesConsoleApp.Infrastructure.Models
{
    public class Information
    {
        [Required]
        public string Category { get; set; }

        public List<Subcategory> Subcategories { get; set; }

    }

    public class Subcategory 
    {
        public string name { get; set; }

    }
}
