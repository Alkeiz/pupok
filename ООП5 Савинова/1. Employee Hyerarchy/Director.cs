using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hierarchy
{
    internal class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, decimal salary, string department)
            : base(name, "Директор", salary)
        {
            Department = department;
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утверждает бюджет для отдела {Department}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Отдел: {Department}");
        }
    }
}
