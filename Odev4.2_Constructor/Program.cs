using System;

namespace Odev4._2_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor : Bir class'ın new ile örneği oluşturulduğunda çalışacak yapıcı bloktur. Aslında class'în adında bir metotdur.
            // Sınıfı ilk kez yapılandırdığımız zaman çalışan bloktur.


            // Birinci senaryoda sadece özellikleri atadık ve ctor bloğunu default olarak kullandık. Birinci senaryoda ikinci senaryoya
            // benzer şekilde Customer customer = new Customer(1, "Ömer", "Kazancı","İzmir"); bir kullanım sergileyemeyiz. 
            // Çünkü ctor parametre almıyor.
            Customer customer = new Customer() { Id = 1, Name = "Ömer", Surname = "Kazancı", City = "İzmir"};


            // İkinci seneryoda ctor bloğu parametre aldı. Ve burada birinci senaryodakine benzer şekilde
            // Customer2 customer2 = new Customer2() { Id = 2, Name = "Hakan", Surname = "Önürme", City = "Ankara" };
            // bir kullanım sergilenemez. Çünkü böyle bir kullanım yoktur.
            Customer2 customer2 = new Customer2(2, "Hakan", "Önürme", "Ankara");


            // Senaryo üç. Yukarıdaki iki kullanımın da olabilmesi için metod overloading yapmam gerekiyor. Bu yüzden hem default
            // ctor hemde parametreli özelleştirdiğim ctor'u kullanıyorum.
            Customer3 customer3 = new Customer3() { Id = 3, Name = "Ayşe", Surname = "Kazancı", City = "Bitlis" };
            Customer3 customer31 = new Customer3(3, "Ayşe", "Kazancı", "Bitlis");

            // Senaryo dört. Üçüncü senaryoda ctor'a gönderdiğim parametrelerden customer31.Name gibi bir kullandımda Name 
            // değişkenine ulaşamıyorum. Peki nasıl ulaşacağız. ctor içinde set ederek. Bunu sıklıkla kullanırız.
            Customer4 customer4 = new Customer4(4, "Yelkin", "Turan", "Diyarbakır");
            Console.WriteLine(customer4.Name);


        }
    }

    class Customer
    {
        // default constructor. Bu blok olsa da olmasa da sınıfta bir nesne üretildiğinde yani new yapıldığında bu blok çalışır.
        public Customer()
        {
            Console.WriteLine("Yapıcı Blok Çalıştı...");
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

    class Customer2
    {
        public Customer2(int id, string name, string surname, string city)
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

    class Customer3
    {
        public Customer3()
        {

        }
        public Customer3(int id, string name, string surname, string city)
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

    class Customer4
    {
        public Customer4()
        {

        }
        public Customer4(int id, string name, string surname, string city)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

}
