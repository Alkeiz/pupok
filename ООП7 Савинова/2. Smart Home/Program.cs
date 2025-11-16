using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switchable[] devices = { new SmartLamp(), new Fan() };

            foreach (var device in devices)
            {
                device.TurnOn();
                device.TurnOff();

                if (device is Levelable levelable)
                {
                    levelable.SetLevel(30);
                }
                Console.WriteLine();
            }
        }
    }
}
