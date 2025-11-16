using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shape = { new Circle(), new Triangle() };
            foreach (var i in shape) Console.WriteLine(i.Draw());
        }
    }
}
