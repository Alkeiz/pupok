using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    internal class Guitar : Instruments
    {
        public override void Play()
        {
            Console.WriteLine("Брень-брень!");
        }
    }
}
