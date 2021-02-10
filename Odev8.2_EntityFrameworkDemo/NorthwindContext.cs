using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev8._2_EntityFrameworkDemo
{
    class NorthwindContext : DbContext  // Veritabanı ile Nesneler arasındaki ilişkiyi kurduğumuz sınıftır.
        // Burada aynı zamanda veritabanına bağlantı açacağız DbContext vasıtasıyla
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);  // Base classın OnConfiguring metodunu çalıştır. Base class da burada DbContext olduğundan
            // DbContext içindeki OnConfiguring metodunu çalışacak.
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = Northwind; Trusted_Connection=True;");  // hangi veritabanı ile çalışacağımızı yazarız.
        }
        public DbSet<Product> Products { get; set; }  // Products tablosu ile Product nesnesini eşleştiriyoruz.
    }
}
