using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; }

        public CheckingAccount(string accountNumber, string owner, decimal overdraftLimit, decimal initialBalance = 0)
            : base(accountNumber, owner, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снятие: -{amount} руб.. Новый баланс: {Balance} руб.");
                if (Balance < 0)
                    Console.WriteLine($"Внимание: использован овердрафт! Задолженность: {-Balance} руб.");
                return true;
            }

            Console.WriteLine("Превышен лимит овердрафта");
            return false;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Лимит овердрафта: {OverdraftLimit} руб.");
        }
    }
}
