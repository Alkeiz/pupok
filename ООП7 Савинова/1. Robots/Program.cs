using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("R2-D2", 100);

            robot.DoWork(); // Энергия: 80
            robot.DoWork(); // Энергия: 60
            robot.Recharge(); // Энергия: 100
            robot.DoWork(); // Энергия: 80
            Console.WriteLine();
        }
    }
}
