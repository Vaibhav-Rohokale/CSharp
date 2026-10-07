using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal abstract class Bank
    {
        public abstract void BankName();
    }

    class HDFC: Bank
    {
        public override void BankName()
        {
            Console.WriteLine("HDFC Bank");

        }
    }
}
