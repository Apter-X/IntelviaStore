using IntelviaStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace IntelviaStore.Api.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Category GetCategory(int departmentId)
        {
            return appDbContext.Categories
                .FirstOrDefault(d => d.CategoryID == departmentId);
        }

        public IEnumerable<Category> GetCategories()
        {
            return appDbContext.Categories;
        }
    }
}
