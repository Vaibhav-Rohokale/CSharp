using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 36) {
                Console.WriteLine("You are failed");
            }
            else if(marks >=36 && marks <= 50)
            {
                Console.WriteLine("C grade");
            }
            else if (marks >50 && marks <= 60)
            {
                Console.WriteLine("B grade");
            }
            else if (marks >60 && marks <= 70)
            {
                Console.WriteLine("b+ grade");
            }
            else if(marks >70 && marks <= 80)
            {
                Console.WriteLine("A grade");
            }
            else if (marks > 80 && marks <= 90){
                Console.WriteLine("A+ grade");
            }
            else if (marks > 90 && marks <= 100){
                Console.WriteLine("O+ grade");
            }
        }
    }
}
