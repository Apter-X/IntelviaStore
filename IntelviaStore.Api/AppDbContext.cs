using IntelviaStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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
        public DbSet<Photo> Galery { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Category Table
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Book" });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 2, CategoryName = "Watch" });

            // Seed Product Table
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 1,
                UpdatedOn = new DateTime(1980, 10, 5),
                ProductName = "Par-delà bien et mal",
                ProductDescription = "Peut - être le temps est - il très proche où l'on s'avisera que la pierre angulaire des édifices sublimes et inconditionnés que les philosophes dogmatiques",
                UnitPrice = 8.60,
                IncludeInCategoryID = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 2,
                UpdatedOn = new DateTime(2011, 2, 5),
                ProductName = "Comprendre l'Empire",
                ProductDescription = "Alain Soral dérange, agace, mais il l'un des rares penseurs de sa génération à se poser et à poser les bonnes questions : celles qui font mal, parfois, et surtout celle que l'on n'aime pas s'entendre poser.",
                UnitPrice = 15.50,
                IncludeInCategoryID = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 3,
                UpdatedOn = new DateTime(2019, 10, 5),
                ProductName = "Festina Chronograph",
                ProductDescription = "Sivis pasem para belum.",
                UnitPrice = 79.99,
                IncludeInCategoryID = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 4,
                UpdatedOn = new DateTime(2020, 10, 5),
                ProductName = "Swatch Originals Big Bold Jellyfish",
                ProductDescription = "Lorem Ipsum Mostrious Giligitamous.",
                UnitPrice = 189.99,
                IncludeInCategoryID = 2
            });

            //Seed Category Table
            modelBuilder.Entity<Photo>().HasData(
                new Photo { PhotoID = 1, PhotoPath = "images/watch01.png", OfTheProductID = 1 });
            modelBuilder.Entity<Photo>().HasData(
                new Photo { PhotoID = 2, PhotoPath = "images/watch02.png", OfTheProductID = 2 });
            modelBuilder.Entity<Photo>().HasData(
                new Photo { PhotoID = 3, PhotoPath = "images/book01.png", OfTheProductID = 3 });
            modelBuilder.Entity<Photo>().HasData(
                new Photo { PhotoID = 4, PhotoPath = "images/book02.png", OfTheProductID = 4 });
        }
    }
}