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

        public HomeController(ILogger<HomeController> logger, Repositories repos)
        {
            _logger = logger;
            repo = repos;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecipeMenu()
        {

            return View("AddRecipe", repo);
        }

        [HttpPost]
        public IActionResult AddRecipe(string title, List<string> ingredient, List<int> amount, List<string> unit, int time, List<string> step)
        {
            Recipe r = new Recipe();

            //foreach (string s in ingredient)
            //{
            //    int index = ingredient.FindIndex
            //    Ingredient i = new Ingredient(s, unit[ingredient);
            //    r.Ingredients.Add()
            //}
            r.Name = title;
            for(int i = 0; i < ingredient.Count; i++)
            {
                Ingredient test = new Ingredient(ingredient[i], unit[i]);
                ModelIngredient model = new ModelIngredient(test, amount[i]);
                r.Ingredients.Add(model);
            }
            r.Time = time;
            foreach(string s in step)
            {
                r.Guide.Add(s);
            }
            repo.CookBook.Add(r);
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
