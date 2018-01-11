using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Directions { get; set; }

    }
}
