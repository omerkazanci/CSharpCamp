using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Kredileri yönettiğim bir sınıf oluşturdum ve içerisini kredi hesaplama yapabilmesi için de bir metod yazdım. Bu base sınıfı da diğer 
    // krediManager sınıflarından inherit ettim. Ancak böyle bir kullanım doğru olmaz. Şöyle ki:

    // Her kredinin belli bir faiz oranı, dosya masrafı veya kendine özgü parametreleri vardır. Yani aşağıdaki hesapla işi ortak bir metod 
    // olmaktan çıkar çünkü hepsi Hesaplama işlemini farklı ele alıyor. 

    // Metodun imzasının aynı olduğu fakat içerisinin farklı olduğu durumlarda biz base de oluşturduğumuz Class'ı class olarak değil de
    // Interface olarak oluştururuz.
    //class CreditManager
    //{
    //    public void Calculate()
    //    {
    //        // Bu bankada birçok kredi türü vardır ve bunları hesaplarken şart bloklarını kullanmak sağlıklı değildir. 
    //        // Çünkü yüzlerce kredi vardır.
    //    }
    //}

    
    // Bir sınıf bir interfaceyi kullanırsa interface içinde tanımlanan metodları içermek zorundadır.
    interface ICreditManager
    {
        void Calculate();
    }
}
