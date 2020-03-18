using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Yahooストア.Models;

namespace Yahooストア.Pages.Categories
{
    public class GenerateModel : PageModel
    {
        private readonly Yahooストア.Data.YahooストアContext _context;

        public GenerateModel(Yahooストア.Data.YahooストアContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}