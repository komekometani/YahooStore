using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Yahooストア.Data.YahooストアContext _context;

        public int? CategoryId { get; set; }

        public DetailsModel(Yahooストア.Data.YahooストアContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }

            CategoryId = Product.CategoryId;

            return Page();
        }
    }
}
