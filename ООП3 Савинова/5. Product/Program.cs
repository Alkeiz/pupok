using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1000, 20);
            product.Name = "Конфета";
            product.Show();
            product.Discount = 10;
            product.Show();
            product.Price = -100;
            Console.ReadLine();
        }
    }
}
