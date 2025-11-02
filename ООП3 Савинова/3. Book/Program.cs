using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Война и мир");
            book1.Pages = 1200;
            book1.Info();

            Book book2 = new Book("");
            book2.Title = "Краткая история";
            book2.Info();
            Console.ReadKey();
        }
    }
}
