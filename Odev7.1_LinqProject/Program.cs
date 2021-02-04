using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev7._1_LinqProject
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

            // Algoritma ile kod yazarak yukarıdaki nesnelerden sonuçlar ortaya çıkaracağız öncelikle.
            Console.WriteLine("-----------------------------ALGORİTMİK-------------------------");
            foreach (Product product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 30)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            // yukarıdaki durum çeşitlendirilebilir. Örneğin işin içine Category sınıfı da dahil olsa ve yukarıda if içinde yazdığımız şartlarla
            // Beraber CategoryName = Bilgisayar olanları getirmek istesem
            foreach (Product product in products)
            {
                foreach (Category category in categories)
                {
                    if (product.UnitPrice > 5000 && product.UnitsInStock > 30 && category.CategoryName == "Bilgisayar")
                    {
                        Console.WriteLine(product.ProductName, category.CategoryName);
                    }
                }
            }
            // Kod daha karmaşık ve döngülerle belleği yoran bir hal aldı. Tabi büyük verilerde gerçek sorgularla beraber yukarıdaki gibi üç ayrı
            // kriterimiz olmaz ve dolayısıyla yukarıdaki kod içinden çıkılmaz bir hal alır.



            // Yukarıdaki karmaşık yapı yerine Linq kullanarak sorgularımızı daha kolay ve daha hızlı yapabilriz. Ayrıca okunabilirlik açısından da avantaj sağlar.
            Console.WriteLine("-----------------------------LİNQ-------------------------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 30 );

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }


            //////////  Metod oluşturarak yukarıdaki işlemleri metod içine alalım
            List<Product> filterProducts = GetProducts(products)


        }

        // Aşağıdaki iki metod Linq'nun kullanılmasındaki önemi anlatıyor.
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 30)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 30).ToList();  // İlk etapta kızıyordu kodumuz.
            // Çünkü Where sınıfı IEnumerable Base sınıfını implemente ediyor ve bu bir array'dir. Bunu listeye çevirdik.
        }


    }



    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }


    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
