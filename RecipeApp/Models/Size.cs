using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    //Enum for the dropdown picker to pick the size of ingredient
    public enum Size
    {
        pinch,
        tsp,
        tbsp,
        gal,
        quart,
        pint,
        cup,
        oz,
        [Display(Name = "fl oz")]
        floz,
        lb,
        ltr,
        mil,
        grams,
        stem,
        stick,
        clove,
        pieces,
        segment
    }
}
