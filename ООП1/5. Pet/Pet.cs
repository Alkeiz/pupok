using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ummmmm
{
    internal class Pet
    {
        private string name;
        private int energy;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    energy = value;
                }
                else
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                }
            }
        }
        public void Play(string name, int energy)
        {
            if (energy >= 20)
            {
                energy = energy - 20;
                Console.WriteLine($"{name} играет, энергия: {energy}.");
            }
            else
            {
                Console.WriteLine($"{name} слишком устал.");
            }
        }
        public void Rest(string name, int energy)
        {
            if (energy <= 70)
            {
                energy = energy + 30;
                Console.WriteLine($"{name} отдыхает, энергия: {energy}.");
            }
            else
            {
                Console.WriteLine($"{name} уже отдохнул.");
            }
        }
    }
}
