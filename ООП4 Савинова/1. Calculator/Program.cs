using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = Calculator.Add(10, 5);
            Console.WriteLine($"10 + 5 = {result1}");
            double result2 = Calculator.Subtract(10, 5);
            Console.WriteLine($"10 - 5 = {result2}");
            double result3 = Calculator.Multiply(10, 5);
            Console.WriteLine($"10 * 5 = {result3}");
            double result5 = Calculator.Divide(10, 5);
            Console.WriteLine($"10 / 5 = {result5}");
            double result4 = Calculator.Divide(10, 0);
            Console.WriteLine($"10 / 0 = {result4}");

            Console.ReadKey();
        }
    }
}
