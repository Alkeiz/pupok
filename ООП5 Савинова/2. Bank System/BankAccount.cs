using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }
        public string Owner { get; }
        public DateTime CreatedDate { get; }

        protected BankAccount(string accountNumber, string owner, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = initialBalance;
            CreatedDate = DateTime.Now;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            Balance += amount;
            Console.WriteLine($"Пополнение: +{amount} руб.. Новый баланс: {Balance} руб.");
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снятие: -{amount} руб.. Новый баланс: {Balance} руб.");
                return true;
            }

            Console.WriteLine("Недостаточно средств");
            return false;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Счет: {AccountNumber}, Владелец: {Owner}, Баланс: {Balance} руб.");
        }
    }
}
