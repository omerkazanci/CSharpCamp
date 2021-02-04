using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"Engin", "Murat", "Kerem", "Halil"};
            // Array'lerde yukarıdaki gibi bir sabitlik var. 4 elemanlı array'i 5e çıkaramıyorum. Bu yüzden kullanışsızdırlar. Onun yerine collection'ları kullanırız.



            List<string> names2 = new List<string>();   // List yapısını kullanabilmek için Generic içindeki sınıfları kullanırız.
            names2.Add("Ömer");
            names2.Add("Selman");
            names2.Add("Hakan");
            Console.WriteLine(names2[0]);


            List<string> names3 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            names3.Add("Sezgin");  // istediğim gibi ekleme yapıp çıkarabilirim.
            names3.Add("Sezer");

        }
    }
}
