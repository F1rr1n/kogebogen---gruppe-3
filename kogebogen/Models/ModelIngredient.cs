using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class ModelIngredient
    {
        public Ingredient Ingredient { get; set; }
        public int amount { get; set; }
        public ModelIngredient(Ingredient ingredient, int amount)
        {
            this.Ingredient = ingredient;
            this.amount = amount;
        }
    }
}
