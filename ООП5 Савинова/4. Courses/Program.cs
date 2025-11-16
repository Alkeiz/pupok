using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = {
            new VideoCourse("C# для начинающих", "Иван Петров", 5000, 25, 1200),
            new TextCourse("Алгоритмы", "Анна Сидорова", 3000, 15, 450),
            new InteractiveCourse("Веб-разработка", "Петр Иванов", 8000, 50, true)
        };

            foreach (var course in courses)
            {
                course.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
