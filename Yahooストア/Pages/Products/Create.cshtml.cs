using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Yahooストア.Data;
using Yahooストア.Models;

namespace Yahooストア.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Yahooストア.Data.YahooストアContext _context;
        public int? CategoryId { get; set; }

        public CreateModel(Yahooストア.Data.YahooストアContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? defaultCategoryId)
        {
            CategoryId = defaultCategoryId;
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", defaultCategoryId);
            return Page();
        }


        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? defaultCategoryId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index",new { SearchCategoryId = defaultCategoryId });
        }
    }
}
