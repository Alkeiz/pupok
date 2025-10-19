using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ummmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 2;
            double radius = circle.Radius;
            circle.GetArea(circle.Radius);
            Console.ReadKey();
        }
    }
}
