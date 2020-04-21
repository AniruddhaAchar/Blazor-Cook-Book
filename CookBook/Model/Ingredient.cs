using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Model
{
    public class Ingredient
    {
        public string Ingredient_Name { get; set; }
        public string Ingredient_Prep_Type { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
}
