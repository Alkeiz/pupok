using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Book
    {
        private readonly string isbn;
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string isbn, string title, string author)
        {
            this.isbn = isbn;
            Title = title;
            Author = author;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Книга: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"ISBN: {isbn}");
        }

        /*public void ChangeISBN(string newIsbn)
        { isbn = newIsbn; }*/ 
        // ^ Попытка изменить поле readonly приведет к ошибке компиляции.
    }
}
