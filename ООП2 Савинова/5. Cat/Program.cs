using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мафусаил", 7);
            Cat cat1 = new Cat("Зандалар");
            cat.Speak();
            cat.Meow();
            cat1.Speak();
            cat1.Meow();
        }
    }
}
