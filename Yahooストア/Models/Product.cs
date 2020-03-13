using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesProduct.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "商品名")]
        public string Name { get; set; }

        [Display(Name = "厚み(ミクロン)")]
        public int Thick { get; set; }
        //public List<SelectListItem> Thicks { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "25", Text = "25" },
        //    new SelectListItem { Value = "30", Text = "30" },
        //    new SelectListItem { Value = "40", Text = "40"  },
        //    new SelectListItem { Value = "50", Text = "50"  },
        //    new SelectListItem { Value = "60", Text = "60"  }
        //};

        [Display(Name = "ヨコ(mm)")]
        public int Width { get; set; }

        [Display(Name = "タテ(mm)")]
        public int Vertical { get; set; }

        [Display(Name = "フタ(mm)")]
        public int? Lid { get; set; }

        [Display(Name = "Yahoo型番")]
        public string YahooModel{ get; set; }

        [Display(Name = "fukuro.in型番")]
        public string FukuroinModel { get; set; }

        [Display(Name = "カテゴリ")]
        public string Category { get; set; }
    }
}
