using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Reptile : Animal
    {
        public string SkinType { get; set; }
        public double PreferredTemperature { get; set; }

        public Reptile(string species, int age, string habitat, string diet,
                      string skinType, double preferredTemperature)
            : base(species, age, habitat, diet)
        {
            SkinType = skinType;
            PreferredTemperature = preferredTemperature;
        }
    }
}
