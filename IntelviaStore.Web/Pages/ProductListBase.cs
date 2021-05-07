using IntelviaStore.Models;
using IntelviaStore.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace IntelviaStore.Web.Pages
{
    public class ProductListBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<Product> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
           Products = (await ProductService.GetProducts()).ToList();
        }
    }
}
