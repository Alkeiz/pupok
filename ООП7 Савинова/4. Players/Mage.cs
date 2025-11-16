using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Mage : Attack, Heal
    {
        public void Attack()
        {
            Console.WriteLine("Маг атакует магией!");
        }

        public void Heal()
        {
            Console.WriteLine("Маг исцеляет раны!");
        }
    }
}
