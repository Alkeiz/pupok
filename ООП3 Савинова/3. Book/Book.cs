using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ошибка: Название не может быть пустым!");
                }
                else
                {
                    title = value;
                }
            }
        }
        public int Pages { get; set; } = 1;
        public bool IsLong => Pages > 300;
        public Book(string title)
        {
            Title = title;
        }
        public void Info()
        {
            string longStatus = IsLong ? "да" : "нет";
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {longStatus}");
        }
    }
}
