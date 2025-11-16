using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal abstract class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Course(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Курс: {Title}");
            Console.WriteLine($"Автор: {Author}, Цена: {Price} руб.");
        }
    }
}
