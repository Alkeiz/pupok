using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, string owner, decimal interestRate, decimal initialBalance = 0)
            : base(accountNumber, owner, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Начислены проценты: +{interest} руб.. Новый баланс: {Balance} руб.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Процентная ставка: {InterestRate}%");
        }
    }
}
