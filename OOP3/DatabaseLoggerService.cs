using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService // buna diyorum ki sen aslında bir ILoggerService alternatifisin.
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
