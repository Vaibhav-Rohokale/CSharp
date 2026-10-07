using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.Details("Soham");
            obj.Salary(100000);

        }
    }
}
