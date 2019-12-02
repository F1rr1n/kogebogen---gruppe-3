using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kogebogen.Models;

namespace kogebogen.Repository
{
    public class Repositories
    {
        public List<Recipe> CookBook = new List<Recipe>();
        
        public Repositories()
        {
            //Spices 
            Ingredient Salt = new Ingredient("Salt", "tsk");
            Ingredient Pepper = new Ingredient("Peber", "tsk");
            Ingredient Oregano = new Ingredient("Oregano", "tsk");
            Ingredient Sugar = new Ingredient("Sukker", "tsk");
            Ingredient Basil = new Ingredient("Basilikum", "tsk");
            Ingredient Chilli = new Ingredient("Chili", "spsk");
            Ingredient Cumin = new Ingredient("Spidskommen", "tsk");
            Ingredient Coriander = new Ingredient("Koriander", "tsk");

            //Ekstra flavour 
            Ingredient Vegatablestock = new Ingredient("Grøntsagsbouillon", "dl");
            Ingredient Beefbroth = new Ingredient("Oksebouillon", "dl");
            Ingredient Calffund = new Ingredient("Kalvefond", "spsk");
            Ingredient CurryPaste = new Ingredient("Karrypasta", "spsk");
            Ingredient Pesto = new Ingredient("Pesto", "tsk");

            //Dry ingredients
            Ingredient Breadcrumbs = new Ingredient("Rasp", "g");
            Ingredient Flour = new Ingredient("Mel", "g");
            Ingredient EggNoodles = new Ingredient("Nudler", "pk");
            Ingredient Rice = new Ingredient("Ris", "g");
            Ingredient Pasta = new Ingredient("Pasta", "g");
            Ingredient Spaghetti = new Ingredient("Spaghetti", "g");
            Ingredient TacoShells = new Ingredient("Taco skaller", null);

            //Vegtables
            Ingredient Onion = new Ingredient("Løg", null);
            Ingredient Garlic = new Ingredient("Hvidløg", "fed");
            Ingredient Chives = new Ingredient("Purløg", null);
            Ingredient Beetroot = new Ingredient("Rødbede", null);
            Ingredient Potato = new Ingredient("Kartofler", "g");
            Ingredient Carrot = new Ingredient("Gulerødder", null);
            Ingredient Broccoli = new Ingredient("Broccoli", "g");
            Ingredient HaricotsVerts = new Ingredient("Grønne bønner", "g");
            Ingredient MixedVegtables = new Ingredient("Blandede grøntsager", "ps");
            Ingredient Pees = new Ingredient("Ærter", "g");
            Ingredient KidneyBeans = new Ingredient("Kidney bønner", "g");

            //Meat 
            Ingredient Beef = new Ingredient("Oksekød", "g");
            Ingredient Bacon = new Ingredient("Bacon", "g");
            Ingredient ChickenBreasts = new Ingredient("Kyllingebryst", null);
            Ingredient Veal = new Ingredient("Kalvekød", "g");

            //Liquid ingredients dip
            Ingredient TomatoSauce = new Ingredient("Tomatsauce", "dåse");
            Ingredient CoconutMilk = new Ingredient("Kokosmælk", "dåse");
            Ingredient Milk = new Ingredient("Mælk", "dl");
            Ingredient Cream = new Ingredient("Fløde", "dl");
            Ingredient Mozarella = new Ingredient("Mozarella", "g");
            Ingredient Butter = new Ingredient("Smør", "g");
            Ingredient Honey = new Ingredient("Flydende honning", "spsk");
            Ingredient Guacamole = new Ingredient("Guacamole", null);
            Ingredient MornaySauce = new Ingredient("Mornay sauce", "pap-bøtte");

            Ingredient Pilsner = new Ingredient("Øl - pilsner", null);

            //Recipes
            Recipe Lasagna = new Recipe();
            Lasagna.Ingredients.Add(new ModelIngredient(Onion, 1));
            Lasagna.Ingredients.Add(new ModelIngredient(Garlic, 3));
            Lasagna.Ingredients.Add(new ModelIngredient(Beef, 500));
            Lasagna.Ingredients.Add(new ModelIngredient(TomatoSauce, 1));
            Lasagna.Ingredients.Add(new ModelIngredient(MornaySauce, 1));
            Lasagna.Ingredients.Add(new ModelIngredient(Salt, 3));
            Lasagna.Ingredients.Add(new ModelIngredient(Pepper, 1));
            Lasagna.Ingredients.Add(new ModelIngredient(Oregano, 2));
            Lasagna.Name = "Lasagne";
            Lasagna.TotalPrice = 40;
            Lasagna.Time = 40;
            CookBook.Add(Lasagna);

            Recipe TomatoSoup = new Recipe();
            TomatoSoup.Ingredients.Add(new ModelIngredient(Butter, 25));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Onion, 1));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Garlic, 1));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Salt, 2));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Sugar, 1));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Carrot, 3));
            TomatoSoup.Ingredients.Add(new ModelIngredient(TomatoSauce, 1));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Basil, 1));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Vegatablestock, 1));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Pepper, 2));
            TomatoSoup.Ingredients.Add(new ModelIngredient(Pasta, 200));
            TomatoSoup.Name = "Tomat suppe";
            TomatoSoup.TotalPrice = 60;
            TomatoSoup.Time = 45;
            CookBook.Add(TomatoSoup);

            Recipe MacNCheese = new Recipe();
            MacNCheese.Ingredients.Add(new ModelIngredient(Pasta, 500));
            MacNCheese.Ingredients.Add(new ModelIngredient(Broccoli, 300));
            MacNCheese.Ingredients.Add(new ModelIngredient(Pees, 350));
            MacNCheese.Ingredients.Add(new ModelIngredient(Bacon, 200));
            MacNCheese.Ingredients.Add(new ModelIngredient(Butter, 50));
            MacNCheese.Ingredients.Add(new ModelIngredient(Flour, 30));
            MacNCheese.Ingredients.Add(new ModelIngredient(Milk, 5));
            MacNCheese.Ingredients.Add(new ModelIngredient(Mozarella, 200));
            MacNCheese.Ingredients.Add(new ModelIngredient(Breadcrumbs, 40));
            MacNCheese.Ingredients.Add(new ModelIngredient(Salt, 1));
            MacNCheese.Ingredients.Add(new ModelIngredient(Pepper, 1));
            MacNCheese.Name = "Mac'N'Cheese deluxe";
            MacNCheese.TotalPrice = 75;
            MacNCheese.Time = 35;
            CookBook.Add(MacNCheese);

            Recipe PastaPesto = new Recipe();
            PastaPesto.Ingredients.Add(new ModelIngredient(Pasta, 600));
            PastaPesto.Ingredients.Add(new ModelIngredient(Pesto, 14));
            PastaPesto.Ingredients.Add(new ModelIngredient(Pees, 200));
            PastaPesto.Ingredients.Add(new ModelIngredient(Mozarella, 165));
            PastaPesto.Ingredients.Add(new ModelIngredient(ChickenBreasts, 3));
            PastaPesto.Ingredients.Add(new ModelIngredient(Salt, 1));
            PastaPesto.Ingredients.Add(new ModelIngredient(Pepper, 1));
            PastaPesto.Name = "Pasta-pestosalat m. kylling";
            PastaPesto.TotalPrice = 50;
            PastaPesto.Time = 20;
            CookBook.Add(PastaPesto);

            Recipe ChilliConCarne = new Recipe();
            ChilliConCarne.Ingredients.Add(new ModelIngredient(KidneyBeans, 100));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Onion, 1));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Beef, 500));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Garlic, 2));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Cumin, 1));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Coriander, 1));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Pesto, 5));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(TomatoSauce, 2));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Beefbroth, 1));
            ChilliConCarne.Ingredients.Add(new ModelIngredient(Rice, 300));
            ChilliConCarne.Name = "Chili con carne";
            ChilliConCarne.TotalPrice = 60;
            ChilliConCarne.Time = 65;
            CookBook.Add(ChilliConCarne);

            Recipe BurningLove = new Recipe();
            BurningLove.Ingredients.Add(new ModelIngredient(Potato, 1500));
            BurningLove.Ingredients.Add(new ModelIngredient(Cream, 1));
            BurningLove.Ingredients.Add(new ModelIngredient(Salt, 1));
            BurningLove.Ingredients.Add(new ModelIngredient(Bacon, 200));
            BurningLove.Ingredients.Add(new ModelIngredient(Onion, 6));
            BurningLove.Ingredients.Add(new ModelIngredient(Chives, 1));
            BurningLove.Ingredients.Add(new ModelIngredient(Beetroot, 400));
            BurningLove.Name = "Brændende kærlighed";
            BurningLove.TotalPrice = 101;
            BurningLove.Time = 45;
            CookBook.Add(BurningLove);

            Recipe Tacos = new Recipe();
            Tacos.Ingredients.Add(new ModelIngredient(Butter, 15));
            Tacos.Ingredients.Add(new ModelIngredient(Beef, 500));
            Tacos.Ingredients.Add(new ModelIngredient(Pilsner, 1));
            Tacos.Ingredients.Add(new ModelIngredient(Garlic, 3));
            Tacos.Ingredients.Add(new ModelIngredient(Calffund, 2));
            Tacos.Ingredients.Add(new ModelIngredient(Honey, 1));
            Tacos.Ingredients.Add(new ModelIngredient(Chilli, 4));
            Tacos.Ingredients.Add(new ModelIngredient(Cumin, 2));
            Tacos.Ingredients.Add(new ModelIngredient(Coriander, 2));
            Tacos.Ingredients.Add(new ModelIngredient(Salt, 1));
            Tacos.Ingredients.Add(new ModelIngredient(Guacamole, 1));
            Tacos.Ingredients.Add(new ModelIngredient(TacoShells, 16));
            Tacos.Name = "Taco";
            Tacos.TotalPrice = 34;
            Tacos.Time = 70;
            CookBook.Add(Tacos);

            Recipe Noodles = new Recipe();
            Noodles.Ingredients.Add(new ModelIngredient(EggNoodles, 1));
            Noodles.Ingredients.Add(new ModelIngredient(ChickenBreasts, 2));
            Noodles.Ingredients.Add(new ModelIngredient(Onion, 1));
            Noodles.Ingredients.Add(new ModelIngredient(Garlic, 2));
            Noodles.Ingredients.Add(new ModelIngredient(Broccoli, 200));
            Noodles.Ingredients.Add(new ModelIngredient(HaricotsVerts, 100));
            Noodles.Name = "Nudler";
            Noodles.TotalPrice = 65;
            Noodles.Time = 90;
            CookBook.Add(Noodles);

            Recipe Wok = new Recipe();
            Wok.Ingredients.Add(new ModelIngredient(ChickenBreasts, 2));
            Wok.Ingredients.Add(new ModelIngredient(MixedVegtables, 1));
            Wok.Ingredients.Add(new ModelIngredient(CurryPaste, 2));
            Wok.Ingredients.Add(new ModelIngredient(CoconutMilk, 1));
            Wok.Ingredients.Add(new ModelIngredient(Rice, 300));
            Wok.Name = "Kyllinge wok";
            Wok.TotalPrice = 80;
            Wok.Time = 30;
            CookBook.Add(Wok);

            Recipe SpaghettiMeatballs = new Recipe();
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(Beef, 500));
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(TomatoSauce, 1));
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(Spaghetti, 250));
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(Flour, 25));
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(Salt, 1));
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(Pepper, 1));
            SpaghettiMeatballs.Ingredients.Add(new ModelIngredient(Milk, 1));
            SpaghettiMeatballs.Name = "Spaghetti med kødboller";
            SpaghettiMeatballs.TotalPrice = 30; //Rigtig pris 
            SpaghettiMeatballs.Time = 30;
            CookBook.Add(SpaghettiMeatballs);
        }
    }
}
