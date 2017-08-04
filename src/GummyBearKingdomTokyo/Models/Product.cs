using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummyBearKingdomTokyo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public string CountryOfOrigin { get; set; }
        public decimal Cost { get; set; }
    }
}
