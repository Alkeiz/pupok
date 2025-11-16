using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Fish : Animal
    {
        public string ScaleType { get; set; }
        public double PreferredDepth { get; set; }

        public Fish(string species, int age, string habitat, string diet,
                   string scaleType, double preferredDepth)
            : base(species, age, habitat, diet)
        {
            ScaleType = scaleType;
            PreferredDepth = preferredDepth;
        }
    }
}
