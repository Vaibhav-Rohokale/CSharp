using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] marks = { 70, 82, 93, 94 };

            //foreach (int i in marks) { 
            //    Console.WriteLine(marks);
            //}
            Console.WriteLine("Enter any language you want to add");
            string techs = Console.ReadLine();

            Console.WriteLine(" ");

            string[] techskills = { "C", "C++", "C#", "Microservices", techs };

            foreach (var tech in techskills) { 
                Console.WriteLine(tech); 
            }

            Console.WriteLine(" ");
            ArrayList mixvalue = new ArrayList();
            mixvalue.Add("BMW");
            mixvalue.Add("Mercedes");

            foreach (var value in mixvalue)
            {
                Console.WriteLine(value);
            }
         }
    }
}
