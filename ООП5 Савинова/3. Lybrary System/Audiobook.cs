using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Audiobook : LibraryItem
    {
        public int Duration { get; set; }
        public string Narrator { get; set; }

        public Audiobook(string title, string author, int year, int duration, string narrator)
            : base(title, author, year)
        {
            Duration = duration;
            Narrator = narrator;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: Аудиокнига, Длительность: {Duration} мин., Диктор: {Narrator}");
        }
    }
}
