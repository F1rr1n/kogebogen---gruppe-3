using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredients> Ingredients;
        public int TotalPrice { get; set; }
        public string Description { get; set; }
        public string Guide { get; set; }
        public int Time { get; set; }
        public string ImageUrl { get; set; }
    }
}
