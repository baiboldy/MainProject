using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string title { get; set; }
        [JsonIgnore]
        public virtual IList<Product> products { get; set; }
    }
}
