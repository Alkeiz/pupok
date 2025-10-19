using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ummmm
{
    internal class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("радиус должен быть больше 0!");
                }
            }
        }
        public void GetArea(double radius)
        {
            radius = Math.PI * (radius * radius);
            Console.WriteLine($"Площадь круга: {radius}");
        }
    }
}
