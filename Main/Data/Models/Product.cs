using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public int? categoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
