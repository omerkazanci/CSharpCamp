using System;
using System.Collections.Generic;
using System.Text;

namespace Odev8._2_EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }  // Int16 = short = veritabanıdaki smallint
    }
}
