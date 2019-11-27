using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Ingredients
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Unit { get; set; }

        public Ingredients (string name, int amount, string? unit)
        {
            this.Name = name;
            this.Amount = amount;
            this.Unit = unit;
        }
    }
}
