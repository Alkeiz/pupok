using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class VideoCourse : Course
    {
        public int VideoCount { get; set; }
        public int TotalDuration { get; set; }

        public VideoCourse(string title, string author, decimal price, int videoCount, int totalDuration)
            : base(title, author, price)
        {
            VideoCount = videoCount;
            TotalDuration = totalDuration;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: Видеокурс, Видео: {VideoCount}, Длительность: {TotalDuration} мин.");
        }
    }
}
