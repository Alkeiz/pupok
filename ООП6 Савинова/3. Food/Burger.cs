using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим Бургер!");
        }
    }
}
