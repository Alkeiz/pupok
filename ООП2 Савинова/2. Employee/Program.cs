using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Маркус", 80000);
            employee.Work();
            Employee employee1 = new Employee("Cерёга");
            employee1.Work();
        }
    }
}

