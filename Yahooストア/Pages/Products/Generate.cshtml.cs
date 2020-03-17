using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Yahooストア.Models;
using Yahooストア.Data;

namespace Yahooストア.Pages.Products
{
    public class GenerateModel : PageModel
    {
        public string title { get; set; }

        private readonly Yahooストア.Data.YahooストアContext _context;

        public GenerateModel(Yahooストア.Data.YahooストアContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.Include(p => p.Category).ToListAsync();
        }

        public async Task OnPostAsync(string CategoryName)
        {
            title = CategoryName;
            Product = await _context.Product.Where(m => m.Category.Name == CategoryName).ToListAsync();
        }

        public string ThickJudge(int Thick)
        {
            switch (Thick)
            {
                case 25:
                    return "#25(薄め)";
                case 30:
                    return "#30(標準)";
                case 40:
                    return "#40(厚口)";
                case 50:
                    return "#50(特厚)";
                case 60:
                    return "#60(超特厚)";
            }

            return "error";
        }
    }
}