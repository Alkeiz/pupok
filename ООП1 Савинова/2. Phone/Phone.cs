using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umm
{
    internal class Phone
    {
        private string brand;
        private int batteryLevel;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    batteryLevel = value;
                }
                else
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                }
            }
        }
        public void UsePhone(string brand, int batteryLevel)
        {
            batteryLevel = batteryLevel - 10;
            Console.WriteLine($"Телефон {brand}, заряд: {batteryLevel}%.");
        }
    }
}
