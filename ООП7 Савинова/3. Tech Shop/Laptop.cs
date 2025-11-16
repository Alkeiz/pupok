using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop
{
    internal class Laptop : Price
    {
        private decimal price;

        public Laptop(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice() => price;
    }
}
