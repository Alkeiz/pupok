using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ummm
{
    internal class BankAccount
    {
        private string owner;
        private double balance;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс должен быть больше или равно 0.");
                }
            }
        }
        public void Deposit(string owner, double balance)
        {
            balance += 500;
            Console.WriteLine($"Владелец {owner}, баланс {balance}.");
        }

        public void Withdraf(string owner, double balance)
        {
            if (balance >= 500)
            {
                balance -= 500;
                Console.WriteLine($"Владелец {owner}, баланс {balance}.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }
    }
}
