using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount : BankOperations, Transfer
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public decimal GetBalance() => balance;

        public void Transfer(decimal amount, BankAccount targetAccount)
        {
            if (amount > 0 && amount <= balance)
            {
                Withdraw(amount);
                targetAccount.Deposit(amount);
                Console.WriteLine($"Перевод {amount}$ выполнен успешно");
            }
            else
            {
                Console.WriteLine("Ошибка перевода: недостаточно средств");
            }
        }
    }
}
