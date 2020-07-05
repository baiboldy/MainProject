using Main.Data.Interfaces;
using Main.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly AppDBContent _dBContent;
        public CategoryServices(AppDBContent dBContent)
        {
            _dBContent = dBContent;
        }

        public async Task<bool> CreateCategory(Category category)
        {
            await _dBContent.Set<Category>().AddAsync(category);
            await _dBContent.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            Category category = await _dBContent.Set<Category>().FirstOrDefaultAsync(c => c.id == id);
            _dBContent.Set<Category>().Remove(category);
            await _dBContent.SaveChangesAsync();
            return true;
        }

        public async Task<IList<Category>> GetCategories()
        {
            return await _dBContent.Category.Include(t => t.subCategories).Where(t => t.parent == null).ToListAsync();
        }

        public Category GetCategory()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory()
        {
            throw new NotImplementedException();
        }
    }
}
