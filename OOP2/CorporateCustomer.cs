using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer : Customer  // CorporateCustomer bir Customer demek bu.
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
