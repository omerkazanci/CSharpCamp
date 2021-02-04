using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3._3
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Bilgileri Eklendi...");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Ad : {0}\nSoyad : {1}\nBirthdate : {2}\nTC : {3}", customer.Name, customer.Surname, customer.BirthDate, customer.TC);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Bilgileri Silindi...");
        }
    }
}
