using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop
{
    internal class Phone : Price, Warranty
    {
        private decimal price;
        private int warrantyMonths;

        public Phone(decimal price, int warrantyMonths)
        {
            this.price = price;
            this.warrantyMonths = warrantyMonths;
        }

        public decimal GetPrice() => price;
        public int GetWarrantyMonths() => warrantyMonths;
    }
}
