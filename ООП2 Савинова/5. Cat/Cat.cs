using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zad5
{
    internal class Cat : Animal
    {
        private int lives;
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value >= 1 && value <= 9)
                    lives = value; ;
            }
        }
        public Cat(string name, int lives) : base(name)
        {this.lives = lives;}
        public Cat(string name) : this(name, 5) { }
        public void Meow()
        {
            if (lives > 1)
            {lives--;}
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {lives}");
        }
    }
}
