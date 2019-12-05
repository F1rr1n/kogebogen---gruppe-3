using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<ModelIngredient> Ingredients = new List<ModelIngredient>();
        public int TotalPrice { get; set; }
        public string Description { get; set; }
        public List<string> Guide = new List<string>();
        public int Time { get; set; }
        public string ImageUrl { get; set; }
        public int ID { get; set; }
        public Recipe()
        {

        }
        public Recipe(string name)
        {
            this.Name = name;
        }
    }
}
