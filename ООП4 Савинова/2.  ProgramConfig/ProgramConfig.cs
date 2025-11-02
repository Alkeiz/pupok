using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class ProgramConfig
    {
        public const string Version = "6.6.6";
        public const string Developer = "Мафусаил Олигархович";

        public static void DisplayProgramInfo()
        {
            Console.WriteLine($"Версия программы: {Version}");
            Console.WriteLine($"Разработчик: {Developer}");
        }
    }
}
