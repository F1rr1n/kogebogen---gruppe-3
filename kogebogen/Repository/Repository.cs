using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kogebogen.Models;

namespace kogebogen.Repository
{
    public class Repository
    {
        public List<Recipe> CookBook;

        public Ingredients Salt;
        public Ingredients Pepper;
        public Ingredients Onion;
        public Ingredients Garlic;
        public Ingredients Beef;
        public Ingredients TomatoSauce;
        public Ingredients Oregano;

        public Repository()
        {
            Recipe Lasagna = new Recipe();
            Lasagna.Ingredients.Add(Pepper);
            Lasagna.Ingredients.Add(Salt);
            Lasagna.Ingredients.Add(Beef);
            Lasagna.Ingredients.Add(Oregano);
            Lasagna.Ingredients.Add(Onion);
            Lasagna.Ingredients.Add(Garlic);
            Lasagna.Ingredients.Add(TomatoSauce);
            CookBook.Add(Lasagna);

        }
    }
}
