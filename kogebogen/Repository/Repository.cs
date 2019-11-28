using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kogebogen.Models;

namespace kogebogen.Repository
{
    public class Repositories
    {
        public static List<Recipe> CookBook = new List<Recipe>();

        public Repositories()
        {
            Ingredient Beef = new Ingredient("Oksekød","g");
            Ingredient Onion = new Ingredient("Løg", null);

            Recipe Lasagna = new Recipe();
            Lasagna.Ingredients.Add(new ModelIngredient(Beef, 200));
            Lasagna.Ingredients.Add(new ModelIngredient(Onion, 1));
            Lasagna.Name = "Lasagna";
            Lasagna.TotalPrice = 40;
            Lasagna.Time = 40;
            CookBook.Add(Lasagna);
            
            Recipe SheperedsPie = new Recipe();
            SheperedsPie.Ingredients.Add(new ModelIngredient(Beef, 300));
            CookBook.Add(SheperedsPie);
        }
    }
}
