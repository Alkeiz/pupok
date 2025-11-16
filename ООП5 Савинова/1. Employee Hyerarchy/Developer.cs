using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hierarchy
{
    internal class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, decimal salary, string language)
            : base(name, "Разработчик", salary)
        {
            ProgrammingLanguage = language;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} пишет код на {ProgrammingLanguage}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Язык программирования: {ProgrammingLanguage}");
        }
    }
}
