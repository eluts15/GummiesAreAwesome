using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GummyBearKingdomTokyo.Models
{
    public class GummyBearKingdomTokyoContext : DbContext
    {
        public GummyBearKingdomTokyoContext (DbContextOptions<GummyBearKingdomTokyoContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
