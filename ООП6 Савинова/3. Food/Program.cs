using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food[] food = { new Burger(), new Pizza(), new Food() };
            foreach (var i in food) i.Eat();
        }
    }
}
