using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_objects
{
    public class Calculator
    {
        public void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The addition is: "+ result);                             
        }

        public void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The Substraction is: " + result);
        }

        public void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The Multiplication is: " + result);
        }

        public void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("The Division is: " + result);
        }
    }
}
