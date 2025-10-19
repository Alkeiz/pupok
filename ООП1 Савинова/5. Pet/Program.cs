using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ummmmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            pet.Name = "Мафусаил";
            pet.Energy = 90;
            int energy = pet.Energy;
            pet.Play(pet.Name, pet.Energy);
            pet.Rest(pet.Name, pet.Energy);
            Console.ReadKey();
        }
    }
}
