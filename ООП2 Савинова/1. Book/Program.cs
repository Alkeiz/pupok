using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Империя вампиров",744);
            book.Read();
            Book book1 = new Book("Бог злости");
            book1.Read();
            Book book2 = new Book();
            book2.Read();
        }
    }
}
