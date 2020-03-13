using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Yahooストア.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Display(Name = "カテゴリ名")]
        public string Name { get; set; }

        [Display(Name = "クッションページURL")]
        public string Url { get; set; }

    }
}
