using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GummyBearKingdomTokyo.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength =3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Name { get; set; }
        [Required]
        [Range(0, 100)]
        public int InStock { get; set; }
        [Required]
        [StringLength(60, MinimumLength =3)]
        public string CountryOfOrigin { get; set; }
        [Required]
        [Range(0, 10000000.00)]
        public decimal Cost { get; set; }
    }
}
