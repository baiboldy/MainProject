using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Main.Data.Interfaces;
using Main.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TD4.TransferData.Response;

namespace Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        private readonly IProductServices _productServices;
        public ProductController(ICategoryServices categoryServices, IProductServices productServices)
        {
            _categoryServices = categoryServices;
            _productServices = productServices;
        }
        [HttpGet("Products")]
        public BaseResponse<IEnumerable<Product>> getProducts()
        {
            IEnumerable<Product> products = _productServices.GetProducts();
            return new BaseResponse<IEnumerable<Product>> { Data = products};
        }
        [HttpPost("CreateProduct")]
        public async Task<BaseResponse<bool>> createProduct([FromBody] Product product)
        {
            bool result = await _productServices.CreateProduct(product);
            return new BaseResponse<bool>(result);
        }
        
    }
}