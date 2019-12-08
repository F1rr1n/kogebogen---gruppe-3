using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Recipe> Favorites = new List<Recipe>();
        public List<Recipe> Own = new List<Recipe>();
        public List<Recipe> Madplan = new List<Recipe>();
        public Madplan madplan = new Madplan();
    }
}
