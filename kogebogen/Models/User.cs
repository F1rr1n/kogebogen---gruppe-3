﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Recipe> Favorites;
        public List<Recipe> Own;
    }
}
