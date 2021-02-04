using System;

namespace Odev3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ömer";
            customer1.Surname = "Kazancı";
            customer1.BirthDate = "08.02.1995";
            customer1.TC = "11111111111";

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Engin",
                Surname = "Demiroğ",
                BirthDate = "01.01.0001",
                TC = "22222222222"
            };

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.List(customer1);
            customerManager1.Delete(customer1);

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.Add(customer2);
            customerManager2.List(customer2);
            customerManager2.Delete(customer2);
        }
    }
}
