using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class Robot : Work, Recharge
    {
        public string Name { get; }
        public int Energy { get; private set; }

        public Robot(string name, int energy)
        {
            Name = name;
            if (energy < 0) Energy = 0;
            else if (energy > 100) Energy = 100;
            else Energy = energy;
        }

        public void DoWork()
        {
            Energy -= 20;
            if (Energy < 0) Energy = 0;
            Console.WriteLine($"{Name} работает. Энергия: {Energy}");
        }

        public void Recharge()
        {
            Energy += 50;
            if (Energy > 100) Energy = 100;
            Console.WriteLine($"{Name} заряжается. Энергия: {Energy}");
        }
    }
}
