using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Vaibhav";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.TrimStart());
            Console.WriteLine(name.TrimEnd());
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Reverse().ToArray());


        }
    }
}
