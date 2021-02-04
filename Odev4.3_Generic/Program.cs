using System;
using System.Collections.Generic;

namespace Odev4._3_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> sehirler = new List<string>();  // List bir Generic Class. Yani belli bir tipde parametre alıp işlem yapar.
            ///// İstersek List<object> yaparak bütün tipleri içine atabileceğimiz bir liste oluşturabiliriz. Çünkü object base class'tır
            ///// yani bütün tiplerin temel sınıfır. Ancak C# tip güvenli bir dil olduğundan bu kullanımı tercih etmeyiz.
            sehirler.Add("İzmir");
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            // Listeler koleksiyonlardır. Bunlar arka planda array bazlıdır. Bunlar arka planda bir array yönetir. 
            // Bizde kendi List sınıfımızı oluşturalım aşağıda.


            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(12);
            sayilar.Add(47);
            sayilar.Add(151);
            sayilar.Add(874);
            Console.WriteLine(sayilar.Count);
        
        }
    }

    class MyList<T>  // Generic Class
    {
        T[] _array;  // normalde array'leri bu şekilde bırakamam. new ile oluşturmam gerekir örneğini. Fakat bunu ctor tarafında halledebiliyorum.
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0]; // List sınıfı aslında ilk new'lendiğinde 0 elemanlı bir array oluşturur. Aynısını yapıyoruz.
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }

}
