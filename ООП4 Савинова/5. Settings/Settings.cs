using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Settings
    {
        private static readonly string configFilePath;
        static Settings()
        {
            configFilePath = "C:\\ProgramData\\MyApp\\config.xml";
        }
        public static void DisplayConfigPath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {configFilePath}");
        }
    }
}
