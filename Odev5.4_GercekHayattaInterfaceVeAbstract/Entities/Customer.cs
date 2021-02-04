using Odev5._4_GercekHayattaInterfaceVeAbstract.Abstract;
using System;

namespace Odev5._4_GercekHayattaInterfaceVeAbstract
{
    public class Customer : IEntity // somut sınıflar çıplak kalıyorsa ve herhangi bir inheritance yada implementasyon almıyorsa ileride nesnellik 
        // zaafiyeti yaşayabiliriz. Sırf bu tip kurallar için IEntity implementasyonu yaptım ki buda bir veritabanı nesnesidir.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
