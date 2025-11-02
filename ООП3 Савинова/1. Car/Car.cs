using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 || value > 300)
                {
                    Console.WriteLine("Ошибка: Скорость не может превышать 300 или быть отрицательной.");
                }
                else
                {
                    speed = value;
                }
            }
        }
        public string Model { get; set; } = "Unknown";
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }
    }
}
