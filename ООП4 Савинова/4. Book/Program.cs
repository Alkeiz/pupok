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
            Book book1 = new Book("978-5-699-12014-7", "Война и мир", "Лев Толстой");
            book1.DisplayBookInfo();

            Book book2 = new Book("978-5-17-090478-3", "Преступление и наказание", "Фёдор Достоевский");
            book2.DisplayBookInfo();
            Console.ReadKey();
        }
    }
}
