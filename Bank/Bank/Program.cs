using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement;

namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 Class1 = new Class1();

            Class1.DisplayWelcomeMessage();
            Class1.DisplayMenu();
            Class1.DisplayExitMessage();
        }
    }
}
