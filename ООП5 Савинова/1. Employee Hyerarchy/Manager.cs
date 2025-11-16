using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hierarchy
{
    internal class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, int teamSize)
            : base(name, "Менеджер", salary)
        {
            TeamSize = teamSize;
        }

        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} проводит собрание для команды из {TeamSize} человек");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размер команды: {TeamSize}");
        }
    }
}
