using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Days
    {
        public string Name { get; set; }  //ugedage
        Recipe recipe;

        public Days(string name)
        {
            this.Name = name;
        }
    }
}
