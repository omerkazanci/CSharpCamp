using MernisServiceReference;
using Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            return true;
        }
    } 
}
