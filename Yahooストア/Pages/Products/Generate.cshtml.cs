using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesProduct.Models;
using Yahooストア.Data;

namespace RazorPagesProduct.Pages.Products
{
    public class GenerateModel : PageModel
    {
        public string ProductName { get; set; }

        private readonly Yahooストア.Data.RazorPagesProductContext _context;

        public GenerateModel(Yahooストア.Data.RazorPagesProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }

        public async Task OnPostAsync(string CategoryName)
        {
            ProductName = CategoryName;
            Product = await _context.Product.Where(m => m.Category.Contains(CategoryName)).ToListAsync();
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