using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Realme", 90);
            phone.Use();
            phone.Use();
            phone.Use();
            phone.BatteryLevel = 150;
            Console.ReadKey();
        }
    }
}
