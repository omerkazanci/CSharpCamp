using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Course kurs1 = new Course();
            kurs1.CourseName = "C#";
            kurs1.Trainer = "Engin Demiroğ";
            kurs1.ViewRate = 68;

            Course kurs2 = new Course();
            kurs2.CourseName = "Java";
            kurs2.Trainer = "Kerem Varış";
            kurs2.ViewRate = 64;

            Course kurs3 = new Course();
            kurs3.CourseName = "Python";
            kurs3.Trainer = "Berkay Bilgin";
            kurs3.ViewRate = 80;

            Course kurs4 = new Course();
            kurs4.CourseName = "C++";
            kurs4.Trainer = "Murat Kurtboğan";
            kurs4.ViewRate = 100;




            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Course[] courses = new Course[] { kurs1, kurs2, kurs3, kurs4 };

            // for döngüsü yerine foreach kullanmak daha mantıklıdır burada. 
            // Çünkü döngü için başlangıç değeri, sınır değeri gibi parametrelere ihtiyaç duymuyoruz.
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Trainer);
            }

        }
    }

    // Aşağıda class içerisine özellikler(properties) yazdık. Bu kullanım class'ın sadece değer tutmasına yarayacak.
    class Course
    {
        public string CourseName { get; set; }
        public string Trainer { get; set; }
        public int ViewRate { get; set; }
    }
}
