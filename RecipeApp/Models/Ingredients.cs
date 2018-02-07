using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Ingredients
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public Quantity Quantity { get; set; }
        public Quantity Quantity2 { get; set; }

    }

    
    enum Quantity
    {
        "1/8,
        BoldTag,
        ItalicsTag,
        HyperlinkTag,
    };

}
