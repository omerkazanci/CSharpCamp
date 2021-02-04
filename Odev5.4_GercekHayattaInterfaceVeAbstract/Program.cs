using Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract;
using Odev5._4_GercekHayattaInterfaceVeAbstract.Concrete;
using System;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            Customer customer = new Customer() { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin" };
            customerManager.Save(customer);
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995, 2, 8), FirstName = "Ömer" });
        }
    }
}
