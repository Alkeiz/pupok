using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace um
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Мафусаил";
            person.Age = 69;
            person.SayHello(person.Name, person.Age);
            Console.ReadKey();
        }
    }
}
