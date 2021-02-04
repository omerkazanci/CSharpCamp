using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    // Class'lar kullanım türlerine göre ikiye ayrılır. 2.si aşağıdaki gibi operasyon(metodları) tutan classlardır.
    class BagManager
    {
        public void Add(Product product) //  Eklemek istediğim şeyi parametre olarak göndereceğim.
        {
            Console.WriteLine("Sepete eklendi : " + product.Name);
        }

        public void Add2(string Name, string Explanation, double Price)
        {
            Console.WriteLine("Ürün sepete eklendi : " + Name);
        }

    }
}
