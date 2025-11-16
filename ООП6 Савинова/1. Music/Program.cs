using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    internal class Program : Instruments
    {
        static void Main(string[] args)
        {
            Instruments[] band = { new Guitar(), new Drum(), new Instruments() };

            foreach (var i in band) i.Play();
        }
    }
}
