using IntelviaStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelviaStore.Api.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int productId)
        {
            return await appDbContext.Products
                .FirstOrDefaultAsync(e => e.ProductID == productId);
        }

        public async Task<Product> AddProduct(Product product)
        {
            var result = await appDbContext.Products.AddAsync(product);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await appDbContext.Products
                .FirstOrDefaultAsync(e => e.ProductID == product.ProductID);

            if (result != null)
            {
                result.UpdatedOn = product.UpdatedOn;
                result.ProductName = product.ProductName;
                result.ProductDescription = product.ProductDescription;
                result.UnitPrice = product.UnitPrice;
                result.IncludeInCategoryID = product.IncludeInCategoryID;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async void DeleteProduct(int productId)
        {
            var result = await appDbContext.Products
                .FirstOrDefaultAsync(e => e.ProductID == productId);
            if (result != null)
            {
                appDbContext.Products.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Product>> Search(string name)
        {
            IQueryable<Product> query = appDbContext.Products;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.ProductName.Contains(name));
            }

            return await query.ToListAsync();
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await appDbContext.Products
                .FirstOrDefaultAsync(e => e.ProductName == name);
        }
    }
}