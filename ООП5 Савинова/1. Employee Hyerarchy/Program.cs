using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
            new Manager("Иван Петров", 80000, 8),
            new Developer("Анна Сидорова", 70000, "C#"),
            new Director("Ольга Иванова", 150000, "IT")
        };

            foreach (var emp in employees)
            {
                emp.DisplayInfo();
                Console.WriteLine();
            }

        // Специфические методы
            ((Manager)employees[0]).ConductMeeting();
            ((Developer)employees[1]).WriteCode();
            ((Director)employees[2]).ApproveBudget();
        }
    }
}

