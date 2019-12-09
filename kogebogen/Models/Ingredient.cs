using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Ingredient
    {
        // Navn på ingrediens
        public string Name { get; set; }
        // Enheds typen på ingrediensen
        public string Unit { get; set; }
        // Constructor
        public Ingredient (string name, string unit)
        {
            this.Name = name;
            this.Unit = unit;
        }
    }
}
