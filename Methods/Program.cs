using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. kullanım
            Product product1 = new Product();  // Burada class'ın instance'ını (örneğini) oluşturduk.
            product1.Id = 1;
            product1.Name = "Üzüm";
            product1.Price = 3.50;
            product1.Explanation = "Manisa üzümü";

            // 2. kullanım
            Product product2 = new Product()
            {
                Id = 2,
                Name = "Kayısı",
                Price = 6.25,
                Explanation = "Malatya kayısısı"
            };

            // Array oluştururken 1. kullanım
            Product[] products = new Product[] { product1, product2 };

            //// Array oluştururken 2. kullanım
            //Product[] products1 = new Product[2];
            //products1[0] = product1;
            //products1[1] = product2;

            //// Array oluştururken 3. kullanım
            //Product[] products2 = { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine("Ürünün adı : {0} --- Ürünün fiyatı : {1} --- Ürünün açıklaması : {2}", product.Name, product.Price, product.Explanation);
                Console.WriteLine("--------------------------------------------------------------------");
            }



            Console.WriteLine("-----------------------------------------Metodlar-------------------------------------------------------------");
            BagManager bagManager = new BagManager();
            bagManager.Add(product1);
            bagManager.Add(product2);

            bagManager.Add2("İncir", "İzmir inciri", 15);
            bagManager.Add2("Kaşar", "Kars Kaşarı", 85.99);

            // Yukarıda farklı şekilde eklemeler yaptık. Şuan iki sistem de çalışıyor bir sorun yok.
            // Add2 metoduna gidip yeni bir parametre daha eklesek yukarıdaki kullanım hata verecek çünkü eksik parametre girmiş olacağız.
            // Ancak Product class ına yeni bir özellik eklesek yukarıda herhangi bir hata almayacağız. 
            // Buna "encapsulation" denir. Kapsülleme, aslında ayrı ayrı yazıp düzensiz olacak yapıyı bir düzene, kapsül içine sokma demek.
        }
    }
}
