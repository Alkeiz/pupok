using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Book
    {
        private string title; //характеристики
        private int pages;
        private bool er_pages;
        public string Title // свойство
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages //свойство
        {
            get { return pages; }
            set
            {
                if (value < 1 || value > 5000)
                {
                    Console.WriteLine("Ошибка. Число не в диапозоне.");
                    er_pages = true;
                }
                else
                {
                    pages = value;
                    er_pages = false;
                }

            }
        }
        // конструктор только с title и page
        public Book(string title, int page)
        {
            Title = title;
            Pages = page;

        }
        public Book(string title) : this(title, 100) { } // конструктор только с параметрами title по умолчанию 100
        public Book() : this("Без названия", 1) { } // конструктор без параметров( название "Без названия", страницы = 1)
        public void Read()
        {
            Console.WriteLine($"Читаю  книгу {title}, на стрнанице: {pages} ");
        }
    }
}
