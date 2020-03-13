using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Yahooストア.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "商品名")]
        public string Name { get; set; }

        [Display(Name = "厚み(ミクロン)")]
        public int Thick { get; set; }

        [Display(Name = "ヨコ(mm)")]
        public int Width { get; set; }

        [Display(Name = "タテ(mm)")]
        public int Vertical { get; set; }

        [Display(Name = "フタ(mm)")]
        public int? Lid { get; set; }

        [Display(Name = "Yahoo型番")]
        public string YahooModel { get; set; }

        [Display(Name = "fukuro.in型番")]
        public string FukuroinModel { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
