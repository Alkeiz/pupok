using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class DVD : LibraryItem
    {
        public int Duration { get; set; }
        public string Rating { get; set; }

        public DVD(string title, string director, int year, int duration, string rating)
            : base(title, director, year)
        {
            Duration = duration;
            Rating = rating;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: DVD, Продолжительность: {Duration} мин., Рейтинг: {Rating}");
        }
    }
}
