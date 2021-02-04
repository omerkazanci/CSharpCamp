using System;
using System.Collections.Generic;

namespace Odev4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////  Kendi Dictionary Sınıfımızı Yazmak...

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(2, "Ömer");
            myDictionary.Add(7, "Selim");
            myDictionary.Add(12, "Ayça");

            // Key değerini vererek 
            myDictionary.Key(12);

        }
    }

    // Birçok arkadaşımız array'ler üzerinden gitmiş. Ben bunu yanlış buldum. Amaç burada Dictionary sınıf oluşturmak iki tane ayrı ayrı
    // List'e oluşturmak değil. Biz nasıl ki List'e oluşturmak için array'leri kullandık. Aynı şekilde Dictionary oluşturmak için ben 
    // List yapısından yaralanabilirim. Zaten bazı yapıların varlığını kabul ederek yenisini inşa ediyoruz.
    class MyDictionary<TKey, TValue>
    {
        List<TKey> _keys;
        List<TValue> _values;
        public MyDictionary()
        {
             _keys = new List<TKey>();
             _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }

        public void Key(TKey key)
        {
            Console.WriteLine(_values[_keys.IndexOf(key)]);
        }

    }
}
