using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Phone
    {
        private int battery;
        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка: Заряд не может превышать 100.");
                }
                else
                {
                    battery = value;
                }
            }
        }
        public string Brand { get; private set; } // У меня так и не получилось решить проблему с init
        public Phone(string brand, int initialCharge)
        {
            Brand = brand;
            BatteryLevel = initialCharge;
        }
        public void Use()
        {
            BatteryLevel = Math.Max(0, BatteryLevel - 10);
            Console.WriteLine($"{Brand}: заряд {BatteryLevel}%.");
        }
    }
}