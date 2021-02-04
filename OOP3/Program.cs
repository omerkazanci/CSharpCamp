using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance ile beraber konuşmamız gereken konulardan biri de Interface'lerdir.

            // Yine bir bankacılık sistemi ve belirli operasyonları konuşalım.


            // 1. Aşağıda ilk olarak nesneler üreteceğiz ve bu nesnelerden metodları çağıracağız.
            PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            personalFinanceCreditManager.Calculate();

            TransportCreditManager transportCreditManager = new TransportCreditManager();
            transportCreditManager.Calculate();

            MorgageCreditManager morgageCreditManager = new MorgageCreditManager();
            morgageCreditManager.Calculate();
            // Yukarıda zaten bir problem yok doğru şekilde sonuç döner.
            // Ama olay aşağıdaki gibi de çalışabiliyor olması.
            ICreditManager personalFinanceCreditManager1 = new PersonalFinanceCreditManager();
            personalFinanceCreditManager1.Calculate();

            ICreditManager transportCreditManager1 = new TransportCreditManager();
            transportCreditManager1.Calculate();

            ICreditManager morgageCreditManager1 = new MorgageCreditManager();
            morgageCreditManager1.Calculate();
            // Demek interface'ler de o interface'yi implemente eden class'ın referans numarasını tutabiliyor.


            ///// 2. Nesneleri teker teker üretip sonrasında metodları teker teker çağırmak mantıklı değildir. Tek bir çatı altında (Manager)
            ///// nesnelerimizi parametre olarak gönderip ilgili metodları çağırırız.
            // Biz kredi hesaplama işlemini yukarıdaki gibi teker teker sınıflar üzerinden yapmayacağız. Bir Manager üzerinden yöneteceğiz.
            ICreditManager personalFinanceCreditManager2 = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager2 = new TransportCreditManager();
            ICreditManager morgageCreditManager2 = new MorgageCreditManager();
            // Her bir kredi türünden referans oluşturduk.
            // Örneğin banka çalışanının ekranında kredi türünü seçmesi ve seçimden sonra kredinin hesaplanması.
            ApplicationManager applicationManager = new ApplicationManager();
            // Çalışan ihtiyaç kredisini seçti
            applicationManager.MakeAnApplication(personalFinanceCreditManager2);
            // Çalışan taşıt kredisini seçti
            applicationManager.MakeAnApplication(transportCreditManager2);
            // Çalışan konut kredisini seçti
            applicationManager.MakeAnApplication(morgageCreditManager2);

            Console.WriteLine("---------------------------------------");
            List<ICreditManager> credits = new List<ICreditManager>() { morgageCreditManager2, personalFinanceCreditManager2 };
            applicationManager.MakeCreditNotification(credits);


            ///// 3. Dependencies injection yaparak birden fazla soyut nesneyi parametre olarak göndeririz.
            /// Aşağıdaki kullanım da doğrudur fakat birden fazla loglama yapabileceğimiz senaryosundan yola çıkarak kodu düzenleriz.
            ILoggerService fileLoggerService = new FileLoggerService();
            applicationManager.MakeAnApplication(morgageCreditManager2, new DatabaseLoggerService());  // böyle de kullanabilirim
            applicationManager.MakeAnApplication(transportCreditManager2, fileLoggerService);  // böyle de


            applicationManager.MakeAnApplication(new ArtisanCreditManager(), new List<ILoggerService>{ new SMSLoggerService(), new DatabaseLoggerService() });
            // Yukarıdaki gibi direk new'leyerek de gönderebilir. Aşağıdaki gibi instance da oluşturabiliriz.
            ICreditManager artisanCreditManager = new ArtisanCreditManager();
            ILoggerService smsLoggerService = new SMSLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { smsLoggerService, databaseLoggerService };
            applicationManager.MakeAnApplication(artisanCreditManager, loggers);

            List<ILoggerService> loggers1 = new List<ILoggerService> { new DatabaseLoggerService(), new SMSLoggerService() };
            applicationManager.MakeAnApplication(artisanCreditManager, loggers);
        }
    }
}
