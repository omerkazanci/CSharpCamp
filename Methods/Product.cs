using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    // Class'lar kullanım türlerine göre ikiye ayrılır. 1.si aşağıdaki gibi özellik tutandır.
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Explanation { get; set; }
        public int StockAmount { get; set; }
    }
}
