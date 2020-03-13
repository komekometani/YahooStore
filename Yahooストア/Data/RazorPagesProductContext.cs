using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesProduct.Models;

namespace Yahooストア.Data
{
    public class RazorPagesProductContext : DbContext
    {
        public RazorPagesProductContext (DbContextOptions<RazorPagesProductContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesProduct.Models.Product> Product { get; set; }
    }
}
