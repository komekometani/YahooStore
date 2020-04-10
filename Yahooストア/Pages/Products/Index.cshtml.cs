using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public string SearchKey { get; set; }

        [BindProperty]
        public int? SearchCategoryId { get; set; }

        public IList<Product> Product { get;set; }

        public SelectList Categories { get; set; }

        public async Task OnGetAsync(string searchKey,int? searchCategoryId = null)
        {
            /*Product ord = new Product
            {
                Name = "test2",
                Thick = 30,
                Width = 0,
                Vertical = 0,
                Lid = 0,
                Header = 0,
                YahooModel = "test",
                FukuroinModel = "test",
                CategoryId = 32
            };

            // Add the new object to the Orders collection.
            _context.Product.Attach(ord);
            _context.Entry(ord).State = EntityState.Modified;
            _context.SaveChanges();*/

            Product = await _context.Product.Include(p => p.Category).ToListAsync();

            if(!string.IsNullOrEmpty(searchKey))
            {
                Product = Product.Where(c =>
                    c.Name.Contains(searchKey) ||
                    c.YahooModel.Contains(searchKey) ||
                    c.FukuroinModel.Contains(searchKey)
                ).ToList();
            }

            if(searchCategoryId.HasValue)
            {
                Product = Product.Where(c => c.CategoryId == searchCategoryId).ToList();
            }
            
            Categories = new SelectList(_context.Category, "Id", "Name");

            SearchCategoryId = searchCategoryId;
        }
    }
}
