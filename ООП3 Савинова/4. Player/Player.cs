using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Player
    {
        private int level;
        private int health;
        public int Level
        {
            get { return level; }
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Ошибка: Уровень должен быть от 1 до 100!");
                }
                else
                {
                    level = value;
                }
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка: Здоровье должно быть от 0 до 100!");
                }
                else
                {
                    health = value;
                }
            }
        }
        public string Name { get; private set; }
        public bool IsAlive => Health > 0;
        public Player(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
        public void TakeDamage(int damage)
        {
            Health = Math.Max(0, Health - damage);
            string aliveStatus = IsAlive ? "да" : "нет";
            Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {aliveStatus}");
        }
    }
}
