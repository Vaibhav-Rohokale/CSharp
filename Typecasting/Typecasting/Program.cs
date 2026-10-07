using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 23.5;
            int value = Convert.ToInt16(price);
            Console.WriteLine(value);

            string number = "1";
            int insert=int .Parse(number);
            Console.WriteLine(insert);

            //implicit

            int a = 10;
            long b = a;
            Console.WriteLine(b);

            //Explicit

            int money = 25;
            string updateMoney = Convert.ToString(money);
            Console.WriteLine(updateMoney);




        }
    }
}
