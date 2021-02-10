using System;
using System.Linq;

namespace Odev8._2_EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entity Framework nedir ?
            // .Net içerisinde ADO.Net adında bir kütüphane bulunur.
            // Bu kütüphane veritabanına bağlanmamızı, kontrol etmemizi, sorgu yazmamızı sağlayan bir kütüphanedir.
            // Bu sayede verileri listeleyebilir, yeni veri ekleyebilir, verilerimizi güncelleyebilir gibi gibi işlemler yapabiliriz.
            // ADO.Net'in kolaylaştırılmış versiyonu olan Dapper vardır.

            // Fakat yukarıda bahsettiğimiz kodlar biraz yorucu. Biz bu süreçleri kolaylaştırmak ve aynı zamanda nesne yönelimli programlama
            // ile ilişkiyi sağlamak ve kolaylaştırmak adına ORM(Object Relational Mapping) dediğimiz yapıları kullanırız. Bunu bize sağlayan
            // yapı Entity Framework'tür. Alternatifi NHibernate vardır fakat EF çok daha iyi durumda olduğu için bunun kullanılmasında yarar var.


            //GetAll();
            GetProductsByCategory(3);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            
            foreach (var Product in northwindContext.Products)
            {
                Console.WriteLine(Product.ProductName);                
            }
            
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.ProductId > categoryId);
            int a = 0;
            foreach (var Product in result)
            {
                Console.WriteLine(Product.ProductName);
                a++;
            }
            Console.WriteLine(a);
        }
    }
}
