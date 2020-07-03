using Main.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Interfaces
{
    public interface ICategoryServices
    {
        Task<IList<Category>> GetCategories();
        Task<bool> CreateCategory(Category category);
        Category GetCategory();
        Task<bool> DeleteCategory(int id);
        bool UpdateCategory();
    }
}
