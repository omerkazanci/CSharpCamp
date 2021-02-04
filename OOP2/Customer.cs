using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer
    {
        // Class'ların iki özelliği vardır.
        // 1. İçerisinde özellikler tutar.
        // 2. İçerisinde operasyonlar tutar.
        // Özellik tuttuğumuz yerde operasyon, operasyon tuttuğumuz yerde özellik tutmayız.


        // Aşağıdaki class önce kötü versiyon olarak oluşturacağız. Bize problem yaratacak seviyede bir nesne üreteceğiz.
        // Hem gerçek hemde tüzel kişiler için özellikleri birarada tutacağız.
        //public int Id { get; set; }
        //public string CustomerNumber { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string CompanyName { get; set; }
        //public string TcNo { get; set; }
        //public string TaxNumber { get; set; }

        // Yukarıda sayılardan oluşan özellikleri long yapmak yerine string yaptık. Eğer bir veri üzerinde matematiksel işlemler yapmıyorsak
        // yani ona sayı görevi vermiyorsak, string olarak yapılandırmak daha iyidir. Gerek belleği kullanma yönünden gerekse farklı sistemlerle 
        // veri uyumluluğunda. Farklı yazılım ortamlarında sayıların karşılıkları ve sınırları farklılık gösterebiliyor. Örneğin sayısal bir TcNo'yu 
        // gidip Excel'e atarsak garip garip karakterler görebiliriz çünkü veri uyumsuzluğu oluşabiliiyor.

        //*** Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsam, o alan o nesneye ait değilmiş gibi duruyorsa demek ki
        // orada soyutlama hatası yapıyoruz.


        // Burada ise olması gereken senaryo
        public int Id { get; set; }
        public string CustomerNumber { get; set; }



    }
}
