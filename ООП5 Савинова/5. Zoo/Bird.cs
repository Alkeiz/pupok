using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Bird : Animal
    {
        public double Wingspan { get; set; }
        public string NestingType { get; set; }

        public Bird(string species, int age, string habitat, string diet,
                   double wingspan, string nestingType)
            : base(species, age, habitat, diet)
        {
            Wingspan = wingspan;
            NestingType = nestingType;
        }
    }
}
