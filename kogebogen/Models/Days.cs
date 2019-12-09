using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Days
    {
        // Navn på dagene i ugen
        public string Name { get; set; }  //ugedage
        // Opskrift til hver dag
        public Recipe Recipe { get; set; }
        // Constructor
        public Days(string name)
        {
            this.Name = name;
        }
    }
}
