using System;

namespace Odev4._1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1); // sayi1 20 olarak karşımıza çıkacak çünkü değer tipler sadece değerle ilgilenir. 
            // sayi1 = 20 ve sayi1 = sayi2 aslında aynı şeydir. 

            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 25, 35, 45 };
            sayilar1 = sayilar2;
            sayilar2[0] = 125;
            Console.WriteLine(sayilar1[0]);  // sayilar1 in birince elemanı da değişir. Çünkü arrayler referans tiplerdir ve sayilar1 ve sayilar2
            // bellekte (heap) aynı yere bakacağından bu değişim o referansı tutan bütün değişkenlerde olacaktır.

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Ömer";
            person2 = person1;
            person1.FirstName = "Engin";
            Console.WriteLine(person2.FirstName); // değişim person1 içinde geçerli. Çünkü ikiside bellekteki aynı adrese bakıyor 
            //ve değişim o adresin referansını tutan bütün nesnelerde oluyor.

        }
    }

    // Base Class
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person // Person class'ından inherit ettim. Yani Person özelliklerini miras aldım,
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {

    }

    class  PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
