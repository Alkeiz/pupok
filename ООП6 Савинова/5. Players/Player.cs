using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
}
