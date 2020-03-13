using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCategory.Models;

namespace Yahooストア.Data
{
    public class RazorPagesCategoryContext : DbContext
    {
        public RazorPagesCategoryContext (DbContextOptions<RazorPagesCategoryContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCategory.Models.Category> Category { get; set; }
    }
}
