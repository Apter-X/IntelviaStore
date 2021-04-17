using System;

namespace IntelviaStore.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CoverPhotoPath { get; set; }
        public Product Product { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double UnitPrice { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Galery Galery { get; set; }
        public int IncludeInCategoryID { get; set; }
        public int CreatedByUserID { get; set; }
    }

    public class Galery
    {
        public int GaleryID { get; set; }
        public int OfTheProductID { get; set; }
        public string PhotoPath { get; set; }
    }
}
