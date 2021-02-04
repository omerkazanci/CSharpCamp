using Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager // Bu durumda interface'yi de dolaylı yoldan referans olarak kullanabileceğiz.
    {
        // yukarıda interface'yi implemente edebilirdim fakat dependencies enjection yaparak initialize ettim. Yani sınıfın constructoruna
        // parametre olarak gönderiyorum.
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }        

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        
    }
}
