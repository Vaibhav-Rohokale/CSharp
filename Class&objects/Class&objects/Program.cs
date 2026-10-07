using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            calculator.Addition( a,b);
            calculator.Substraction( a,b);
            calculator.Multiplication( a,b);
            calculator.Division( a,b);       


        }
    }
}
