using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class TextCourse : Course
    {
        public int ChapterCount { get; set; }
        public int TextVolume { get; set; }

        public TextCourse(string title, string author, decimal price, int chapterCount, int textVolume)
            : base(title, author, price)
        {
            ChapterCount = chapterCount;
            TextVolume = textVolume;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: Текстовый курс, Глав: {ChapterCount}, Объем: {TextVolume} стр.");
        }
    }
}
