using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Alex", 5, 100);
            player.TakeDamage(30);
            player.TakeDamage(40);
            player.TakeDamage(30);
            player.Level = 0;
            Console.ReadKey();
        }
    }
}
