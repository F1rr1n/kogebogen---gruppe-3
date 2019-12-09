using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kogebogen.Models
{
    public class Madplan
    {
        // Array af alle dage på en uge
        public Days[] days = new Days[] { new Days("Mandag"), new Days("Tirsdag"),
            new Days("Onsdag"), new Days("Torsdag"),
            new Days("Fredag"), new Days("Lørdag"), new Days("Søndag") };
        // Holder opskriften vi vil sætte ind på madplanen
        public Recipe rHolder { get; set; }
        // Den samlede pris på alle opskrifterne
        public int price { get; set; }

        // Metode der laver samler alle priserne
        public int Price(int a)
        {
            price += a;
            return price;
        }
        
    }
}
