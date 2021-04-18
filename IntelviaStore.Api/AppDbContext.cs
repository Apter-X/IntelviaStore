using IntelviaStore.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace IntelviaStore.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Watch" });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 2, CategoryName = "Book" });

            // Seed Employee Table
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 1,
                ProductName = "Produit 01",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 1, PhotoPath = "images / watch01.png" },
                IncludeInCategoryID = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 2,
                ProductName = "Produit 02",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 2, PhotoPath = "images/book01.png" },
                IncludeInCategoryID = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 3,
                ProductName = "Produit 03",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 2, PhotoPath = "images/watch02.png" },
                IncludeInCategoryID = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 4,
                ProductName = "Produit 04",
                UnitPrice = 1.99,
                UpdatedOn = new DateTime(1980, 10, 5),
                Galery = new Galery { GaleryID = 2, PhotoPath = "images/book02.png" },
                IncludeInCategoryID = 4
            });
        }
    }
}