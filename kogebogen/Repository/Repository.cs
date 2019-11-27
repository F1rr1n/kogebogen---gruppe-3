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
        public Ingredients Oregano;
        public Ingredients Sugar;
        public Ingredients Basil;
        public Ingredients Vegatablestock;
        public Ingredients BeefBroth;
        public Ingredients Calffund;
        public Ingredients Chili;
        public Ingredients Cumin;
        public Ingredients CurryPaste;
        public Ingredients Coriander;
        public Ingredients Breadcrumbs;
        public Ingredients Milk;



        public Ingredients Onion;
        public Ingredients Garlic;
        public Ingredients Chives;
        public Ingredients Beets; 

        public Ingredients Beef;
        public Ingredients Bacon;
        public Ingredients ChickenBreasts;
        public Ingredients Veal;

        public Ingredients TomatoSauce;
        public Ingredients CoconutMilk;
        public Ingredients Pesto;
        public Ingredients Cream;
        public Ingredients Mozzarella;
        public Ingredients Flour;
        public Ingredients Butter;
        public Ingredients Honey;
        public Ingredients Guacaole;

        public Ingredients Pilsner;


        public Ingredients Potatoes;
        public Ingredients Carrots;
        public Ingredients Broccoli;
        public Ingredients HaricotsVerts;
        public Ingredients MixedVegables;
        public Ingredients Pees;
        public Ingredients EggNoddles;
        public Ingredients Rice;
        public Ingredients Pasta;
        public Ingredients Spaghetti;
        public Ingredients KidneyBeans;
        public Ingredients Tacoshells;
        

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

            Recipe TomatoSoup = new Recipe();
            TomatoSoup.Ingredients.Add(Butter);
            TomatoSoup.Ingredients.Add(Pasta);
            TomatoSoup.Ingredients.Add(Vegatablestock);
            TomatoSoup.Ingredients.Add(Carrots);
            TomatoSoup.Ingredients.Add(Basil);
            TomatoSoup.Ingredients.Add(Garlic);
            TomatoSoup.Ingredients.Add(Onion);
            TomatoSoup.Ingredients.Add(Salt);
            TomatoSoup.Ingredients.Add(Sugar);
            TomatoSoup.Ingredients.Add(TomatoSauce);
            TomatoSoup.Ingredients.Add(Pepper);
            TomatoSoup.Ingredients.Add(Butter);
            TomatoSoup.Ingredients.Add(Butter);
            TomatoSoup.Ingredients.Add(Butter);
            CookBook.Add(TomatoSoup);


            Recipe BurningLove = new Recipe();
            BurningLove.Ingredients.Add(Potatoes);
            BurningLove.Ingredients.Add(Cream);
            BurningLove.Ingredients.Add(Salt);
            BurningLove.Ingredients.Add(Bacon);
            BurningLove.Ingredients.Add(Onion);
            BurningLove.Ingredients.Add(Chives);
            BurningLove.Ingredients.Add(Beets);
            CookBook.Add(BurningLove);


            Recipe Tacos = new Recipe();
            Tacos.Ingredients.Add(Calffund);
            Tacos.Ingredients.Add(Butter);
            Tacos.Ingredients.Add(Pilsner);
            Tacos.Ingredients.Add(Garlic);
            Tacos.Ingredients.Add(Honey);
            Tacos.Ingredients.Add(Chili);
            Tacos.Ingredients.Add(Cumin);
            Tacos.Ingredients.Add(Coriander);
            Tacos.Ingredients.Add(Salt);
            Tacos.Ingredients.Add(Guacaole);
            Tacos.Ingredients.Add(Tacoshells);
            CookBook.Add(Tacos);


            Recipe ChiliConCarne = new Recipe();

            ChiliConCarne.Ingredients.Add(KidneyBeans);
            ChiliConCarne.Ingredients.Add(Onion);
            ChiliConCarne.Ingredients.Add(Beef);
            ChiliConCarne.Ingredients.Add(Garlic);
            ChiliConCarne.Ingredients.Add(Cumin);
            ChiliConCarne.Ingredients.Add(Coriander);
            ChiliConCarne.Ingredients.Add(Chili);
            ChiliConCarne.Ingredients.Add(TomatoSauce);
            ChiliConCarne.Ingredients.Add(BeefBroth);
            ChiliConCarne.Ingredients.Add(Rice);
            CookBook.Add(ChiliConCarne);


            Recipe PastaPesto = new Recipe();
            PastaPesto.Ingredients.Add(Pasta);
            PastaPesto.Ingredients.Add(Pesto);
            PastaPesto.Ingredients.Add(Pees);
            PastaPesto.Ingredients.Add(Mozzarella);
            PastaPesto.Ingredients.Add(ChickenBreasts);
            PastaPesto.Ingredients.Add(Salt);
            PastaPesto.Ingredients.Add(Pepper);
            CookBook.Add(PastaPesto);

            Recipe ChickenNoddles = new Recipe();
            ChickenNoddles.Ingredients.Add(EggNoddles);
            ChickenNoddles.Ingredients.Add(ChickenBreasts);
            ChickenNoddles.Ingredients.Add(Onion);
            ChickenNoddles.Ingredients.Add(Garlic);
            ChickenNoddles.Ingredients.Add(Broccoli);
            ChickenNoddles.Ingredients.Add(Chili);
            CookBook.Add(ChickenNoddles);

            Recipe MacnCheese = new Recipe();
            MacnCheese.Ingredients.Add(Pasta);
            MacnCheese.Ingredients.Add(Pees);
            MacnCheese.Ingredients.Add(Bacon);
            MacnCheese.Ingredients.Add(Butter);
            MacnCheese.Ingredients.Add(Milk);
            MacnCheese.Ingredients.Add(Mozzarella);
            MacnCheese.Ingredients.Add(Salt);
            MacnCheese.Ingredients.Add(Pepper);
            MacnCheese.Ingredients.Add(Breadcrumbs);
            MacnCheese.Ingredients.Add(Flour);
            CookBook.Add(MacnCheese);


            Recipe Spaghettimeatballs = new Recipe();
            Spaghettimeatballs.Ingredients.Add(Spaghetti);
            Spaghettimeatballs.Ingredients.Add(Veal);
            Spaghettimeatballs.Ingredients.Add(TomatoSauce);
            Spaghettimeatballs.Ingredients.Add(Flour);
            Spaghettimeatballs.Ingredients.Add(Salt);
            Spaghettimeatballs.Ingredients.Add(Pepper);
            Spaghettimeatballs.Ingredients.Add(Milk);
            Spaghettimeatballs.Ingredients.Add(Spaghetti);
            CookBook.Add(Spaghettimeatballs);

            Recipe Wok = new Recipe();
            Wok.Ingredients.Add(Rice);
            Wok.Ingredients.Add(ChickenBreasts);
            Wok.Ingredients.Add(MixedVegables);
            Wok.Ingredients.Add(CoconutMilk);
            Wok.Ingredients.Add(CurryPaste);
            CookBook.Add(Wok);
        }
    }
}
