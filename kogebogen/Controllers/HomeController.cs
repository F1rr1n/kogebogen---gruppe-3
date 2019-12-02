﻿using System;
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
            for (int i = 0; i < ingredients.Count;i++)
            {
                Ingredient inter = new Ingredient(ingredients[i], unit[i]);
                ModelIngredient mo = new ModelIngredient(inter, amount[i]);
                r.Ingredients.Add(mo);
            }
            r.Time = time;
            r.Description = description;
            repo.CookBook.Add(r);
            u.Own.Add(r);
            return View("Index");

        }

        [HttpPost]
        public IActionResult RemoveRecipe(string r)
        {
            foreach(Recipe test in repo.CookBook)
            {
                if(test.Name == r)

                {
                    u.Own.Remove(test);
                }
            }
            
            return View("Myrecipes",u);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
