 using System;
using System.Collections.Generic;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama (DRY)
            //değer tutucu, alias

            // Aslında aşağıda tip belirlerken string, int vs yerine 'var' kullanabiliriz. Sonrasında değere göre C# değişken tipini kendisi tanıyabilir.
            // Fakat yukarıda bahsettiğimiz tip güvenli bir kullanım senaryosu olduğundan 'var' kullanımını tercih etmeyiz.
            string kategoriEtiketi = "Kategoriler";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
