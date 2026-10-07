using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Example
{
    internal class Calculate
    {
        public void Calc(int a, int b, char op)
        {
            // this is function defination;


            if (op == '+')
            {
                Console.WriteLine(a + b);
            }
            else if (op == '-')
            {
                Console.WriteLine(a - b);
            }
            else if (op == '*')
            {
                Console.WriteLine(a * b);
            }
            else if (op == '/')
            {
                Console.WriteLine(a / b);
            }
        }

        //no parameter no ret
        public void DisplayName()
        {
            Console.WriteLine("Vaibhav");
        }

        // parameter and no return type;

        public void DisplayName1(String name)
        {
            Console.WriteLine(name);
        }

        // return value no parameter

        public string GetName()                                               
        {
            return "Vaibhav";  // String name = calculator.GetName()
        }


        //With parameter with return type
        public String DisplayName2(String name) {

            return name;
        }
        
    }
}
