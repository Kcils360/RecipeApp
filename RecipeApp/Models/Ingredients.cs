using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Ingredients
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public string Quantity { get; set; }
        public Size Size { get; set; }
        public string Ingredient { get; set; }


    }
}
