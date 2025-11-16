using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        protected decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}, Должность: {Position}");
        }
    }
}
