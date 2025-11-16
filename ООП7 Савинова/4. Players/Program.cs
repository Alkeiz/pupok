using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Players
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] characters = { new Warrior(), new Mage() };

            Console.WriteLine("Атакующие:");
            foreach (var character in characters)
            {
                if (character is Attack attacker)
                {
                    attacker.Attack();
                }
            }

            Console.WriteLine("Лечащие:");
            foreach (var character in characters)
            {
                if (character is Heal healer)
                {
                    healer.Heal();
                }
            }
            Console.WriteLine();

        }
    }
}
