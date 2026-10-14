using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertLeftPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int k = 0; k < (n - i); k++) 
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\0");
            }
        }
    }
}
