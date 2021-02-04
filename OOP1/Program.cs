using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Name = "Klavye";
            product1.UnitPrice = 220;
            product1.UnitsInStock = 42;


            Product product2 = new Product 
            {
                Id = 2,
                CategoryId = 7,
                Name = "Koltuk",
                UnitPrice = 675,
                UnitsInStock = 13
            };

            // PascalCase     camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //////////////   Parametre ve Referans Tipler arasındaki ilişki
            ///ProductManager içerisinde tanımladığımız sayi ve isim değiştirme metotları işe yarayacak mı ?
            
            ProductManager productManagerDeneme1 = new ProductManager();
            productManagerDeneme1.ChangeName(product1); // product nesnesi Product sınıfından oluşturulduğu için referans tip'dir 
            // Referans tip'lerde bütün atamalar referansın numarasıyla yapılır yani bellekteki adresiyle. Burada product1 i yolladığımızda
            // aslında bellekteki adres üzerinden gider. product1'in bellekteki yerini referans verir. Yani bellekteki fiziksel lokasyonu göndermiş oluruz.
            Console.WriteLine(product1.Name); // "Değiştir" sonucunu basar.


            int sayi = 125;
            ProductManager productManagerDeneme2 = new ProductManager();
            productManagerDeneme2.ChangeNumber(sayi);  // sayi ProductManager tarafında değiştirilemez. Nedeni ise sayi değer tip olduğundan
            // metoda sadece değer gider. Metod içinde aynı isimle değerin tutulması önemli değildir. Burada tanımlanan ve metod içindeki
            // parametreden gelen sayi'nin birbirleriyle alakası yoktur.
            Console.WriteLine(sayi);  // 125 sonucunu basar.




        }
    }
}
