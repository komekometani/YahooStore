﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Yahooストア.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "商品名")]
        public string Name { get; set; }

        [Display(Name = "厚み(μ)")]
        public int Thick { get; set; }

        [Display(Name = "ヨコ(mm)")]
        public int Width { get; set; }

        [Display(Name = "タテ(mm)")]
        public int Vertical { get; set; }

        [Display(Name = "フタ(mm)")]
        public int? Lid { get; set; }

        [Display(Name = "ヘッダー(mm)")]
        public int? Header { get; set; }

        [Display(Name = "Yahoo型番")]
        public string YahooModel { get; set; }

        [Display(Name = "fukuro.in型番")]
        public string FukuroinModel { get; set; }

        [Display(Name = "カテゴリ名")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
