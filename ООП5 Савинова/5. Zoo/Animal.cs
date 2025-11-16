using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        public Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Животное издает звук");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"Животное ест: {Diet}");
        }
    }
}
