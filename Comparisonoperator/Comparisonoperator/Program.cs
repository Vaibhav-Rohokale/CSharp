using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisonoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //    Console.WriteLine("Enter the age: ");
        //    int age = Convert.ToInt16(Console.ReadLine());

        //    if (age > 18)
        //    {
        //        Console.WriteLine("You are eligible to vote ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You are not eligible ");
        //    }

            //Console.WriteLine("Enter the Grade: ");
            //int Grade = Convert.ToInt16(Console.ReadLine());

            //if (Grade < 35)
            //{
            //    Console.WriteLine("you are failed ");
            //}
            //else if (Grade <= 35 && Grade >= 50)
            //{
            //    Console.WriteLine("B Grade");
            //}
            //else if (Grade > 50 && Grade <= 70)
            //{
            //    Console.WriteLine("A Grade");
            //}
            //else if (Grade > 70 && Grade <= 90)
            //{
            //    Console.WriteLine("A+ Grade");
            //}
            //else {
            //    Console.WriteLine("Outstanding");
            
            //}

            //int a = 5;
            //a += 5;
            //Console.WriteLine(a);

            //int value = 10;
            //Console.WriteLine(++value);
            //Console.WriteLine(--value);

            //ternary operator
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt16(Console.ReadLine());

            string Output = (age >= 18)? "You are eligible to vote" : "you are not eligible to vote";
            Console.WriteLine(Output);

        }
}
}
