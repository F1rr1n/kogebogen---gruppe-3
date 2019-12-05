using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kogebogen.Models;
using kogebogen.Repository;

namespace kogebogen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Repositories repo;
        private User u;

        public HomeController(ILogger<HomeController> logger, Repositories repos, User user)
        {
            _logger = logger;
            repo = repos;
            u = user;
        }

        public IActionResult Index()
        {
            repo.CookBook.Add(new Recipe("Pasta al dente"));
            u.Own.Add(repo.CookBook[3]);
            u.Own[0].Guide.Add("test1");
            u.Own[0].Guide.Add("test2");
            u.Own[0].Guide.Add("test3");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecipe()
        {

            return View(repo);
        }
        [HttpPost]
        public IActionResult Recipes()
        {
            return View(repo);
        }
        [HttpPost]
        public IActionResult Myrecipes()
        {
            return View(u);
        }

        [HttpPost]
        public IActionResult AddRecipeTest(string title, List<string> ingredients, List<int> amount, List<string> unit, int time, string description, List<string> guide)
        {
            Recipe r = new Recipe();
            r.Name = title;
            for (int i = 0; i < ingredients.Count; i++)
            {
                Ingredient inter = new Ingredient(ingredients[i], unit[i]);
                ModelIngredient mo = new ModelIngredient(inter, amount[i]);
                r.Ingredients.Add(mo);
            }
            r.Time = time;
            r.Description = description;
            foreach (string s in guide)
            {
                r.Guide.Add(s);
            }
            r.ID = repo.CookBook.Count;
            repo.CookBook.Add(r);
            u.Own.Add(r);
            return View("Index");

        }
        public IActionResult Addfav(int r)
        {

            Recipe test = repo.CookBook.Find(x => x.ID == r);
            if (!u.Favorites.Contains(test))
            {
                u.Favorites.Add(test);

            }

            return View("Addfav", u);
        }

        [HttpPost]
        public IActionResult Addtofoodplan(int r)
        {

            Recipe test = repo.CookBook.Find(x => x.ID == r);
            if (u.Madplan.Count <= 6)
            {
                u.Madplan.Add(test);

            }

            return View("Addtofoodplan", u);
        }
        [HttpPost]
        public IActionResult RemoveRecipe(int r)
        {
            Recipe test = repo.CookBook.Find(x => x.ID == r);
            u.Own.Remove(test);
            return View("Myrecipes", u);
        }

        [HttpPost]
        public IActionResult EditRecipeOpen(int r)
        {
            Recipe rekt = repo.CookBook.Find(x => x.ID == r);
            return View("EditRecipe", rekt);
        }
        [HttpPost]
        public IActionResult EditRecipe(int id, string title, List<string> ingredients, List<int> amount, List<string> unit, int time, string description, List<string> guide)
        {
            Recipe test = repo.CookBook.Find(x => x.ID == id);
            test.Name = title;
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (i >= test.Ingredients.Count)
                {
                    Ingredient inter = new Ingredient(ingredients[i], unit[i]);
                    ModelIngredient mo = new ModelIngredient(inter, amount[i]);
                    test.Ingredients.Add(mo);
                }
                else
                {
                    test.Ingredients[i].Ingredient.Name = ingredients[i];
                    test.Ingredients[i].Ingredient.Unit = unit[i];
                    test.Ingredients[i].amount = amount[i];
                }
            }
            test.Time = time;
            test.Description = description;
            for (int i = 0; i < guide.Count; i++)
            {
                if (i >= test.Guide.Count)
                {
                    test.Guide.Add(guide[i]);
                }
                else
                {
                    test.Guide[i] = guide[i];
                }
            }
            repo.CookBook[id] = test;
            return View("Myrecipes", u);
        }

        [HttpPost]
        public IActionResult TheRecipe(int OpskriftID)
        {
            Recipe rekt = repo.CookBook.Find(x => x.ID == OpskriftID);
            return View(rekt);
        }

        [HttpPost]
        public IActionResult Search(string searchValue)
        {
            RecipeHolder test = new RecipeHolder();
            var meh = repo.CookBook.Where(x => x.Name.Contains(searchValue));
            foreach(var v in meh)
            {
                test.recipes.Add(v);
                test.recipeCounter++;
            }
            // var test2 = repo.CookBook.Where(x => x.Ingredients[].Ingredient.Name.Contains(searchValue));
            foreach (Recipe r in repo.CookBook)
            {
                for(int i = 0; i <r.Ingredients.Count; i++)
                {
                    if(r.Ingredients[i].Ingredient.Name.Contains(searchValue))
                    {
                        test.recipes.Add(r);
                    }
                }
            }

            return View(test);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
