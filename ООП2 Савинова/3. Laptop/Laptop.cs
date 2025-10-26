using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Laptop : Device
    {
        private int ram;
        private int battery;
        private bool er_ram;
        private bool er_battery;

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Ошибка.");
                    er_ram = true;
                }
                else
                {
                    ram = value;
                    er_ram = false;
                }

            }

        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка.");
                    er_battery = true;
                }
                else
                {
                    battery = value;
                    er_battery = false;
                }

            }
        }
        public Laptop(string Brand, int ram, int battery) : base(Brand)
        {
            Ram = ram;
            Battery = battery;
        }
        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ {ram} ГБ, заряд: {battery}.");
        }
    }
}
