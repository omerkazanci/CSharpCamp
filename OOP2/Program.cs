using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bugün soyutlamayı konuşacağız. Soyutlama bizi sektörde değerli yapacak olandır. İyi derecede bilinmesi iş garantisi teşkil edebilir.

            // Bir bankada müşterileri, kredileri, şubeleri, çalışanları yönetmek vs işleri vardır.
            // İki tür müşteri vardır. Gerçek ve tüzel müşteriler. Şimdi bir müşteri yönetim sistemi kuracağız.


            //// Aşağıda gerçek bir müşteri bilgileri girelim
            //Customer customer = new Customer();
            //customer.Id = 1;
            //customer.Name = "Ömer";
            //customer.Surname = "Kazancı";
            //customer.TcNo = "2222222222222";
            //customer.CustomerNumber = "12345";
            //customer.CompanyName = "?";  // Şimdi buranın gerçek müşteriyle ne alakası var ? Demek soyutlama hatası yapmışım.
            //// Gerçek Müşteri ve Tüzel Müşteri. Aynı nesne ikisi yerine de kullanılamaz.
            //// Bu teknik SOLID tarafından 



            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.CustomerNumber = "123456";
            individualCustomer.Name = "Ömer";
            individualCustomer.Surname = "Surname";
            individualCustomer.TcNo = "134532435434";

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNumber = "54341";
            corporateCustomer.CompanyName = "Kodlama.io";
            corporateCustomer.TaxNumber = "234324";


            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();
            // Yukarıdaki kodların anlamı özetle şudur.
            // Customer sınıfı hem IndividualCustomer sınıfının bellekteki referansını tutar 
            // hemde CorporateCustomer sınıfının bellekteki referansını tutar.
            // Zaten new'in anlamı bellekte yeni bir referans oluştur demek. 


            CustomerManager customerManager = new CustomerManager();
            // Bu bilgiler doğrultusunda metod içine gönderebildiğim parametreler aşağıdaki gibi.
            customerManager.Add(individualCustomer);
            customerManager.Add(corporateCustomer);
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            // Olay tamamen referans tip ile alakalı. Base sınıfın onu inherit eden sınıfların referansını tutabilmesidir.

            // Yukarıda CustomerManager'a parametre olarak Customer'ları gönderebiliyor olabilmemiz bir polymorphism(çok biçimlilik) örneğidir.
        }
    }
}
