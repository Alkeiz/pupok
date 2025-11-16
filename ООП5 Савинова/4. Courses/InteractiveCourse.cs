using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class InteractiveCourse : Course
    {
        public int ExerciseCount { get; set; }
        public bool HasCheckingSystem { get; set; }

        public InteractiveCourse(string title, string author, decimal price, int exerciseCount, bool hasCheckingSystem)
            : base(title, author, price)
        {
            ExerciseCount = exerciseCount;
            HasCheckingSystem = hasCheckingSystem;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: Интерактивный курс, Упражнений: {ExerciseCount}");
            Console.WriteLine($"Система проверки: {(HasCheckingSystem ? "Да" : "Нет")}");
        }
    }
}
