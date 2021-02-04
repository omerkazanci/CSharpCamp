using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager  // veya PruductService diye isimlendirebiliriz.
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " güncellendi.");
        }



        public void ChangeName(Product product)
        {
            product.Name = "Değiştir";
        }


        public void ChangeNumber(int sayi)  // gönderilen değer burada sayi'ya eşitlenir. O değeri sayi tutar bu metod içinde. 
            // İsim benzerliği önemsizdir. Biz burada aslında bağımsız ve değeri 125 olup sayi tarafından tutulan değeri 25 yaptık.
        {
            sayi = 25;
        }

    }
}
