using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntelviaStore.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CoverPhotoPath { get; set; }
        public ICollection<Product> Product { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double UnitPrice { get; set; }
        public ICollection<Photo> Galery { get; set; }
        public int CreatedByUserID { get; set; }
        [ForeignKey("Category")]
        public int IncludeInCategoryID { get; set; }
    }

    public class Photo
    {
        public int PhotoID { get; set; }
        public string PhotoPath { get; set; }
        [ForeignKey("Product")]
        public int OfTheProductID { get; set; }
    }
}
