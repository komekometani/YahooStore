using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yahooストア.Models;

namespace Yahooストア.Data
{
    public class YahooストアContext : DbContext
    {
        public YahooストアContext (DbContextOptions<YahooストアContext> options)
            : base(options)
        {
        }

        public DbSet<Yahooストア.Models.Category> Category { get; set; }

        public DbSet<Yahooストア.Models.Product> Product { get; set; }
    }
}
