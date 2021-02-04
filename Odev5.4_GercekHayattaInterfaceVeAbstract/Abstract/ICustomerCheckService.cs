using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
