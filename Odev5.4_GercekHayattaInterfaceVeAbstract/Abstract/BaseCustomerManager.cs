using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        } 
    }
}
