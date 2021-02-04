using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //class MorgageCreditManager : CreditManager
    //{

    //}

    class MorgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }

} 