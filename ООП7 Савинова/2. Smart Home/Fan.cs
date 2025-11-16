using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class Fan : Switchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Вентилятор включен");
        }

        public void TurnOff()
        {
            Console.WriteLine("Вентилятор выключен");
        }
    }
}
