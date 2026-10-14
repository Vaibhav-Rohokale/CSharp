using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Class1
    {
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Bank Management System!");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
        }

        public void DisplayExitMessage()
        {
            Console.WriteLine("Thank you for using the Bank Management System. Goodbye!");
        }
    }
}
