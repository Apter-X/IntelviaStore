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
        public IEnumerable<Category> Categories { get; set; }

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
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 1, PhotoPath = "images / watch01.png" }
            };

            Product p2 = new Product
            {
                ProductID = 2,
                ProductName = "Produit 02",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 2, PhotoPath = "images/book01.png" }
            };

            Product p3 = new Product
            {
                ProductID = 3,
                ProductName = "Produit 03",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 2, PhotoPath = "images/watch02.png" } 
            };

            Product p4 = new Product
            {
                ProductID = 4,
                ProductName = "Produit 04",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 2, PhotoPath = "images/book02.png" }
            };

            Products = new List<Product> { p1, p2, p3, p4 };
        }
    }
}
