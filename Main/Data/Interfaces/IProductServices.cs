using Main.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        Task<bool> CreateProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProdcut(int id);
    }
}
