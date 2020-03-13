using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCategory.Models;
using Yahooストア.Data;

namespace RazorPagesCategory.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Yahooストア.Data.RazorPagesCategoryContext _context;

        public IndexModel(Yahooストア.Data.RazorPagesCategoryContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
