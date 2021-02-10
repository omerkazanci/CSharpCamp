using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev7._3_LinqSorguları
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


            var result = products.Any(p => p.ProductName == "Acer Laptop"); // İçinde arar. True yada False döner
            Console.WriteLine(result);

            var result1 = products.Find(p => p.ProductId == 3); // Product nesnesini bulur.
            Console.WriteLine(result1.ProductName);

            var result2 = products.FindAll(p => p.ProductName.Contains("top"));  // içinde top geçen isimleri buldu.
            Console.WriteLine(result2);  // liste döndü.

            LinkWhereAscDesc(products);
            WhereDifferentUsing(products);
        }

        private static void WhereDifferentUsing(List<Product> products)
        {
            var result6 = from p in products // product içindeki her bir p.
                          select p;  // p'yi seç
            foreach (var item in result6)
            {
                Console.WriteLine(item.QuantityPerUnit);
            }

            var result7 = from p in products
                          where p.UnitPrice > 3000
                          select p;
            foreach (var item in result7)
            {
                Console.WriteLine(item.QuantityPerUnit);
            }

            var result8 = from p in products
                          where p.UnitPrice > 3000
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select p;
            foreach (var item in result8)
            {
                Console.WriteLine(item.QuantityPerUnit);
            }
        }

        private static void LinkWhereAscDesc(List<Product> products)
        {
            // Single Line Query
            var result3 = products.Where(p => p.ProductName.Contains("top"));
            foreach (var item in result3)
            {
                Console.WriteLine(item.ProductName);
            }

            var result4 = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice); // sıraya koymak için orderby. zorunlu değil
            foreach (var item in result4)
            {
                Console.WriteLine(item.ProductName);
            }

            var result5 = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            // farzedelim ki birimFiyat eşit ve ben ürünAdın'na göre z'den a'ya sıralayacağım.
            foreach (var item in result5)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
     
}
