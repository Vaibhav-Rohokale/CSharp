using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Decisison making :
            // types of conditional statements:
            //1. if statements
            //2. if else
            //3. else if
            //4. nesting if
            //5. switch
            //6. Ternary 

            Console.WriteLine("Enter the Age: ");
            int age= Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You can vote !!");
            }
            else
            {
                Console.WriteLine("You cannot vote");
            }
        }
    }
}
