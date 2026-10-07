using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{
    internal class Logger
    {
        public static void information(string message) {
            Console.WriteLine(message);
        }

        public static void Error(string message) {  
            Console.WriteLine(message);
        }

        public static void Warning(string message)
        {
            Console.WriteLine(message);
        }
    }
}
