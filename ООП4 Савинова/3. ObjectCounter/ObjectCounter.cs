using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class ObjectCounter
    {
        private static int objectCount = 0;
        public ObjectCounter()
        {
            objectCount++;
        }
        public static void DisplayObjectCount()
        {
            Console.WriteLine($"Количество созданных объектов: {objectCount}");
        }
    }
}
