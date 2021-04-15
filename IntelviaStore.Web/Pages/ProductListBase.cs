using IntelviaStore.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntelviaStore.Web.Pages
{
    public class ProductListBase : ComponentBase
    {
        public IEnumerable<Product> Products { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadProducts();
            return base.OnInitializedAsync();
        }

        private void LoadProducts()
        {
            Product p1 = new Product
            {
                ProductID = 1,
                ProductName = "Produit 01",
                UnitPrice = 1.99,
                CreatedOn = new DateTime(1980, 10, 5),
                Category = new Category { CategoryID = 1, CategoryName = "Montre" },
                PhotoPath = "images/watch01.png"
            };

            Product p2 = new Product
            {
                ProductID = 1,
                ProductName = "Produit 01",
                UnitPrice = 1.99,
                CreatedOn = new DateTime(1980, 10, 5),
                Category = new Category { CategoryID = 2, CategoryName = "Livre" },
                PhotoPath = "images/book01.png"
            };

            Product p3 = new Product
            {
                ProductID = 1,
                ProductName = "Produit 01",
                UnitPrice = 1.99,
                CreatedOn = new DateTime(1980, 10, 5),
                Category = new Category { CategoryID = 1, CategoryName = "Montre" },
                PhotoPath = "images/watch02.png"
            };

            Product p4 = new Product
            {
                ProductID = 1,
                ProductName = "Produit 01",
                UnitPrice = 1.99,
                CreatedOn = new DateTime(1980, 10, 5),
                Category = new Category { CategoryID = 2, CategoryName = "Livre" },
                PhotoPath = "images/book02.png"
            };

            Products = new List<Product> { p1, p2, p3, p4 };
        }
    }
}