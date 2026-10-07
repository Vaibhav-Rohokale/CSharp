using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputconversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The Addition is: " + (firstNumber + secondNumber));
            Console.WriteLine("The Substraction is: " + (firstNumber - secondNumber));
            Console.WriteLine("The Multiplication  is: " + (firstNumber * secondNumber));
            Console.WriteLine("The Division is: " + (firstNumber / secondNumber));

        }
    }
}
