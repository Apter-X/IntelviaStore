using IntelviaStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntelviaStore.Api.Models
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int productId);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        void DeleteProduct(int productId);

        Task<Product> GetProductByName(string name);
        Task<List<Product>> Search(string name);
    }
}
