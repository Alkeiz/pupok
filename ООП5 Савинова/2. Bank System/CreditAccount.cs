using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; }
        public DateTime DueDate { get; }

        public CreditAccount(string accountNumber, string owner, decimal creditLimit, DateTime dueDate)
            : base(accountNumber, owner, creditLimit)
        {
            CreditLimit = creditLimit;
            DueDate = dueDate;
        }

        public override bool Withdraw(decimal amount)
        {
            // Для кредитного счета снятие = использование кредита
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (amount <= Balance) // Balance здесь = доступный кредит
            {
                Balance -= amount;
                Console.WriteLine($"Кредитные средства использованы: {amount} руб.. Доступно: {Balance} руб.");
                return true;
            }

            Console.WriteLine("Превышен кредитный лимит");
            return false;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Кредитный счет: {AccountNumber}, Владелец: {Owner}");
            Console.WriteLine($"Кредитный лимит: {CreditLimit} руб., Использовано: {CreditLimit - Balance} руб.");
            Console.WriteLine($"Дата погашения: {DueDate:dd.MM.yyyy}");
        }
    }
}
