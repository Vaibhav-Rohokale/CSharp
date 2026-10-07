using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            obj.DisplayName("HDFC");
            obj.CreditAmount(1000);
            obj.DebitAmount(300);
            obj.WithdrawAmount(500);
            obj.DisplayBalance(500);

        }
    }
}
