﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Yahooストア.Data;
using Yahooストア.Models;

namespace Yahooストア.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Yahooストア.Data.YahooストアContext _context;

        public IndexModel(Yahooストア.Data.YahooストアContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Category).ToListAsync();
        }
    }
}
