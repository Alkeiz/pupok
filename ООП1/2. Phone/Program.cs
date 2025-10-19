using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using umm;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Brand = "Vertu";
            phone.BatteryLevel = 99;
            phone.UsePhone(phone.Brand, phone.BatteryLevel);
            Console.ReadKey();
        }
    }
}
