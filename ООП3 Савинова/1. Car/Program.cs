using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford Mustang", 150);
            car.Drive();
            car.Speed = 400;
            car.Speed = -50;
            car.Drive();
            Console.ReadKey();
        }
    }
}
