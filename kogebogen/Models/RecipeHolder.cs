using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class RecipeHolder
    {
        public List<Recipe> recipes = new List<Recipe>();
        public int recipeCounter { get; set; }
    }
}
