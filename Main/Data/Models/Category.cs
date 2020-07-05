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
        public int? parentId { get; set; }
        [JsonIgnore]
        public virtual Category parent { get; set; }
        public virtual ICollection<Category> subCategories { get; set; }
    }
}
