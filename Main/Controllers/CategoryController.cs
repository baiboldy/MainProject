using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Main.Data.Interfaces;
using Main.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TD4.TransferData.Response;

namespace Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        private readonly IProductServices _productServices;
        public CategoryController(ICategoryServices categoryServices, IProductServices productServices)
        {
            _categoryServices = categoryServices;
            _productServices = productServices;
        }
        [HttpPost("CreateCategory")]
        public async Task<BaseResponse<bool>> createCategory([FromBody] Category category)
        {
            await _categoryServices.CreateCategory(category);
            return new BaseResponse<bool>(true);
        }
        [HttpGet("GetCategories")]
        //[Authorize(Roles = "User")]
        public async Task<BaseResponse<IList<Category>>> getCategories()
        {
            IList<Category> categories = await _categoryServices.GetCategories();
            return new BaseResponse<IList<Category>>(categories);
        }
        [HttpDelete("DeleteCategory")]
        public async Task<BaseResponse<bool>> deleteCategory(int id)
        {
            bool result = await _categoryServices.DeleteCategory(id);
            return new BaseResponse<bool>(result);
        }
    }
}