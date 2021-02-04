using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {

        public void MakeAnApplication(ICreditManager creditManager)
        {
            // Başvuran bilgilerini değerlendirme
            // Burada Krediyi hesaplayalım şimdi. Tüm başvuruları buradan yönetip gelecek her krediyi tek çatı altında burada hesaplayacağım.
            // Benim elimde bütün kredi türlerinin referansını tutan bir ICreditManager var. Yukarıya parametre olarak onu gönderip istediğim
            // kredi türünü parametre olarak gönderebilirim. Artık kredi türünden bağımsız.

            // Aşağıda, gönderdiğim kredi türünün bellekteki o kredinin Calculate'i çalışır. Yani ben buraya ihtiyaç kredisini göndersem, 
            // bellekteki ihtiyaç kredisinin Hesapla'sı çalışır.
            creditManager.Calculate();

        }

        // Müşteri istediği kredi ile alakalı ön bilgi almak istediğinde...
        public void MakeCreditNotification(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }

        // Engin hoca yukarıdaki metodu düzenledi ama ben burada metod overloading yapacağım. Adım adım görmek adına.
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)  // burada yaptığımız şey dependencies enjection(method injection).
        // Benim başvuru işlemlerimde hangi loglama yada hangi kredi olduğuna dair bilgi yok. Parametre kısmında sadece soyut halleri var ben somut hallerini enjekte ediyorum.
        {
            creditManager.Calculate();
            loggerService.Log();
        }


        // Bir düzenleme daha yaptık. Tekrardan metod overloading
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggers)
        {
            creditManager.Calculate();
            foreach (var logger in loggers)
            {
                logger.Log();
            }
        }

    }
}
