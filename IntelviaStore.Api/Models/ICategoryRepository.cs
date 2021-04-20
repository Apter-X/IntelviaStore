using IntelviaStore.Models;
using System.Collections.Generic;

namespace IntelviaStore.Api.Models
{
    interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int categoryId);
    }
}
