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
            // Midlertidig test værdier
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
            return View();
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
            // Laver noge nye objekter til at holder værdierne
            Recipe recipe = new Recipe();
            Ingredient ingredient;
            ModelIngredient mIngredient;
            recipe.Name = title;
            // Gennemgår ingredienserne lavet og lægger dem til listen af ingredienser på opskriften
            for (int i = 0; i < ingredients.Count; i++)
            {
                // Sætter værdierne og gemmer dem 
                ingredient = new Ingredient(ingredients[i], unit[i]);
                mIngredient = new ModelIngredient(ingredient, amount[i]);
                recipe.Ingredients.Add(mIngredient);
            }
            recipe.Time = time;
            recipe.Description = description;
            // Indsætter step-by-step guide kronologisk på opskriften
            foreach (string s in guide)
            {
                recipe.Guide.Add(s);
            }
            recipe.ID = repo.CookBook.Count;
            repo.CookBook.Add(recipe);
            u.Own.Add(recipe);
            return View("Index");

        }
        public IActionResult Addfav(int id)
        {
            // Finder opskriften baseret på dets ID og sætter det på et nyt Recipe objekt
            Recipe recFav = repo.CookBook.Find(rec => rec.ID == id);
            // Hvis opskriften ikke allerede findes i favoritter tilføjes den
            if (!u.Favorites.Contains(recFav))
            {
                u.Favorites.Add(recFav);
            }

            return View("Addfav", u);
        }

        [HttpPost]
        public IActionResult Addtofoodplan(int id)
        {
            // Finder opskriften via ID og føjer den til vores madplan
            Recipe recPlan = repo.CookBook.Find(rec => rec.ID == id);
            u.madplan.rHolder = recPlan;
            return View("Addtofoodplan", u);
        }
        [HttpPost]
        public IActionResult AddToPlan(string day, int rec)
        {
            // Finder opsrkiften via ID
            Recipe recipe = repo.CookBook.Find(recipe => recipe.ID == rec);
            // Finder dagen baseret på dagen og sætter opskriften ind på dagen
            u.madplan.days.Where(recipe => recipe.Name == day).Single().Recipe = recipe;
            // Kører en metode der samler den totale pris for madplanen
            u.madplan.Price(recipe.TotalPrice);
            return View("ShowPlan", u);
        }
        [HttpPost]
        public IActionResult RemoveRecipe(int id)
        {
            // Finder opskriften via ID
            Recipe recipe = repo.CookBook.Find(recipe => recipe.ID == id);
            // Fjerne opskriften med det nye opskrift objekt
            u.Own.Remove(recipe);
            return View("Myrecipes", u);
        }

        [HttpPost]
        public IActionResult EditRecipeOpen(int id)
        {
            // Finder opskriften via ID og sender den tilbage til viewet for at blive redigeret
            Recipe rekt = repo.CookBook.Find(recipe => recipe.ID == id);
            return View("EditRecipe", rekt);
        }
        [HttpPost]
        public IActionResult EditRecipe(int id, string title, List<string> ingredients, List<int> amount, List<string> unit, int time, string description, List<string> guide)
        {
            // Finder opskrift via ID
            Recipe recipe = repo.CookBook.Find(recipe => recipe.ID == id);
            recipe.Name = title;
            // Gennemgår den nye liste af ingredienser
            for (int i = 0; i < ingredients.Count; i++)
            {
                // Hvis antallet af ingredienser er højere end før laver den nogle nye
                if (i >= recipe.Ingredients.Count)
                {
                    Ingredient inter = new Ingredient(ingredients[i], unit[i]);
                    ModelIngredient mo = new ModelIngredient(inter, amount[i]);
                    recipe.Ingredients.Add(mo);
                }
                // Hvis ikke, så bare sæt de nye værdier ind på de eksisterende ingredienser
                else
                {
                    recipe.Ingredients[i].Ingredient.Name = ingredients[i];
                    recipe.Ingredients[i].Ingredient.Unit = unit[i];
                    recipe.Ingredients[i].amount = amount[i];
                }
            }
            recipe.Time = time;
            recipe.Description = description;
            for (int i = 0; i < guide.Count; i++)
            {
                // Hvis der er kommet nye trin, tilføj dem
                if (i >= recipe.Guide.Count)
                {
                    recipe.Guide.Add(guide[i]);
                }
                // Hvis trinnet allerede eksisterede, sæt den nye værdi
                else
                {
                    recipe.Guide[i] = guide[i];
                }
            }
            repo.CookBook[id] = recipe;
            return View("Myrecipes", u);
        }

        [HttpPost]
        public IActionResult TheRecipe(int OpskriftID)
        {
            // Finder opskriften via ID
            Recipe recipe = repo.CookBook.Find(x => x.ID == OpskriftID);
            return View(recipe);
        }

        [HttpPost]
        public IActionResult Search(string searchValue)
        {
            // Vi laver et nyt objekt til at holde alle de opskrifter vi finder
            RecipeHolder rHolder = new RecipeHolder();
            // Finder alle opskrifter hvor søge værdien indgår i navnet
            var meh = repo.CookBook.Where(x => x.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
            // Gennemgår de værdier fundet, giver dem med og tæller op for hvor mange opskrifter der er fundet
            foreach (var v in meh)
            {
                rHolder.recipes.Add(v);
                rHolder.recipeCounter++;
            }
            // var test2 = repo.CookBook.Where(x => x.Ingredients[].Ingredient.Name.Contains(searchValue));
            // Gennemgår alle opskrifterne og deres ingredienser for at se om vores søgeværdi findes derinde
            foreach (Recipe r in repo.CookBook)
            {
                for (int i = 0; i < r.Ingredients.Count; i++)
                {
                    if (r.Ingredients[i].Ingredient.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        rHolder.recipes.Add(r);
                    }
                }
            }

            return View(rHolder);
        }
        [HttpPost]
        public IActionResult AddToShoppingList(int id)
        {
            Recipe recipe = repo.CookBook.Find(recipe => recipe.ID == id);
            foreach (ModelIngredient ingredient in recipe.Ingredients)
            {
                if (!u.ShoppingList.Contains(ingredient))
                {
                    u.ShoppingList.Add(ingredient);
                }
            }
            return View("Index");
        }
        public IActionResult ShoppingList()
        {
            return View(u);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
