using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Entity : Varlık 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        
        // Bu tip class'larda sadece özellikler olur.

        // Silmek, güncellemek, eklemek, listelemek, aramak, filtrelemek gibi operasyonlara temel olarak CRUD operasyonları deriz.
    }
}
