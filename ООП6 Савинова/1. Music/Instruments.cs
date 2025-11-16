using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    internal class Instruments
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыка...");
        }
    }
}
