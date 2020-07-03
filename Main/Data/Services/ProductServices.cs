using Main.Data.Interfaces;
using Main.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Services
{
    public class ProductServices : IProductServices
    {
        private readonly AppDBContent _dBContent;
        public ProductServices(AppDBContent dBContent)
        {
            _dBContent = dBContent;
        }

        public async Task<bool> CreateProduct(Product product)
        {
            var result = await _dBContent.Set<Product>().AddAsync(product);
            await _dBContent.SaveChangesAsync();
            return true;
        }

        public bool DeleteProdcut(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _dBContent.Set<Product>().Include(c => c.Category).ToList();
                //return _dBContent.Product.Include(c => c.Category).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
