using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class SmartLamp : Switchable, Levelable
    {
        private int level;

        public void TurnOn()
        {
            level = 100;
            Console.WriteLine($"Лампа включена. Уровень: {level}");
        }

        public void TurnOff()
        {
            level = 0;
            Console.WriteLine($"Лампа выключена. Уровень: {level}");
        }

        public void SetLevel(int level)
        {
            if (level < 0) this.level = 0;
            else if (level > 100) this.level = 100;
            else this.level = level;
            Console.WriteLine($"Уровень лампы установлен: {this.level}");
        }
    }
}
