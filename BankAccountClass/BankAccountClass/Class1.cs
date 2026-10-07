using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClass
{
    internal partial class Class1
    {
        public void DisplayName(String Name)
        {
            Console.WriteLine("The name is: " + Name);
        }

        public void CreditAmount(int CreditAmount)
        {
            Console.WriteLine("Credited Amount is: " + CreditAmount);
        }

        public void WithdrawAmount(int WithdrawAmount)
        {
            Console.WriteLine("Withdrawn Amount is: " + WithdrawAmount);
        }

        public void DisplayBalance(int DisplayBalance)
        {
            Console.WriteLine("Total Balance is: " + DisplayBalance);
        }


    }

    internal partial class Class1
    {
        public void DebitAmount(int DebitAmount)
        {
            Console.WriteLine("The Debited Amount is: " + DebitAmount);
        }
    }
}
