using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value;
            string name="Vaibhav";
            char grade;

            grade = 'A';
            Console.WriteLine(name.ToUpper());

            bool result=false;
            Console.WriteLine(result);

            DateTime date;
            date = DateTime.Now;
            Console.WriteLine(date);
            
            Console.WriteLine(grade);

            float price;
            price = 54.8f;
            Console.WriteLine(price);

            decimal amount;
            amount = 100.5m;
            Console.WriteLine(amount);
            
        }
    }
}
