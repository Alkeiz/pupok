using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryItem[] items = {
            new Book("Война и мир", "Лев Толстой", 1869, 1225, "978-5-389-07464-1"),
            new Magazine("National Geographic", "National Geographic Society", 2023, 5, "Ежемесячный"),
            new DVD("Интерстеллар", "Кристофер Нолан", 2014, 169, "PG-13"),
            new Audiobook("1984", "Джордж Оруэлл", 1949, 845, "Иван Иванов")
        };

            foreach (var item in items)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
