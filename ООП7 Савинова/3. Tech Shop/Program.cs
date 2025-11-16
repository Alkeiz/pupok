using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TechShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] products = { new Phone(500, 24), new Laptop(1200) };
            decimal totalCost = 0;

            foreach (var product in products)
            {
                Console.WriteLine($"Товар: {product.GetType().Name}");
                if (product is Price priced)
                {
                    totalCost += priced.GetPrice();
                    Console.WriteLine($"Цена: {priced.GetPrice()}$");
                }

                if (product is Warranty warranty)
                {
                    Console.WriteLine($"Гарантия: {warranty.GetWarrantyMonths()} месяцев");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Общая стоимость: {totalCost}$");
            Console.WriteLine();
        }
    }
}
