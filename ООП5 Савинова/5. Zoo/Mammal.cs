using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Mammal : Animal
    {
        public string FurType { get; set; }
        public int GestationPeriod { get; set; }

        public Mammal(string species, int age, string habitat, string diet,
                     string furType, int gestationPeriod)
            : base(species, age, habitat, diet)
        {
            FurType = furType;
            GestationPeriod = gestationPeriod;
        }
    }
}
