using IntelviaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelviaStore.Web.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
