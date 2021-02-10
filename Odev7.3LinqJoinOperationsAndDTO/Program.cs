using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev7._3LinqJoinOperationsAndDTO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>()
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 10000, UnitsInStock = 24},
                new Product{ProductId = 2, CategoryId = 2, ProductName = "Redmi Telefon", QuantityPerUnit = "6 GB Ram", UnitPrice = 3250, UnitsInStock = 93},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 12500, UnitsInStock = 11},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 4500, UnitsInStock = 114},
                new Product{ProductId = 5, CategoryId = 1, ProductName = "Dell Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6300, UnitsInStock = 18},
            };

            // ClassicLinqTest(products);

            var result = from p in products
                         join c in categories on p.CategoryId equals c.CategoryId
                         where c.CategoryId is 2
                         select new ProductDTO { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice, CategoryName = c.CategoryName };
            foreach (var item in result)
            {
                Console.WriteLine("{0}---{1}", item.CategoryName, item.ProductName);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 3000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDTO { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice, };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }

    class ProductDTO // Data Transformation Object
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
