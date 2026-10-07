using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();
            obj.Calc(10, 20, '*');  // this is function call ;
            obj.Calc(15, 17, '+');

            obj.DisplayName();
            obj.DisplayName1("Developer");

            String name = obj.GetName();
            Console.WriteLine("Name is: " + name);

            obj.DisplayName2("Vaibhav");
            Console.WriteLine(name);
        }
    }
}
