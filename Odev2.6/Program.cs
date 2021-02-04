using System;

namespace Odev2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class'ın özellikleri tanımlanırken iki ayrı kullanım vardır.

            // 1. kullanım
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Çikolatalı Gofret";
            product1.Amount = "375";
            product1.UnitPrice = "1.25";
            product1.Brand = "Ülker";

            // 2. kullanım
            Product product2 = new Product
            {
                Id = 2,
                Name = "Kazak",
                Amount = "126",
                UnitPrice = "49.99",
                Brand = "Mavi"
            };

            Product[] products = new Product[] { product1, product2 };

            for (var i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Amount);
            }


            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Adı : {0} -- Ürünün Markası : {1}", product.Name, product.Brand);
            }

            var sayi = 0;
            while (sayi < products.Length)
            {
                Console.WriteLine(products[sayi].UnitPrice);
                sayi++;
            }
        }
    }


    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string UnitPrice { get; set; }
        public string Brand { get; set; }
    }
}
