using System;

namespace IntelviaStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Category Category { get; set; }
        public double UnitPrice { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public string PhotoPath { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string PhotoPath { get; set; }
    }
}
