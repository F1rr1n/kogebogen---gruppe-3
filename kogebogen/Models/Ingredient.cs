using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Unit { get; set; }

        public Ingredient (string name, string unit)
        {
            this.Name = name;
            this.Unit = unit;
        }
    }
}
