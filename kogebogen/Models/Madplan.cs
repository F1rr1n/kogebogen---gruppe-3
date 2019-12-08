using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Madplan
    {
        public Days[] days = new Days[] { new Days("Mandag"), new Days("Tirsdag"),
            new Days("Onsdag"), new Days("Torsdag"),
            new Days("Fredag"), new Days("Lørdag"), new Days("Søndag") };
        public Recipe rHolder { get; set; }
        public int price { get; set; }

        public int Price(int a)
        {
            price += a;
            return price;
        }
        
    }
}
