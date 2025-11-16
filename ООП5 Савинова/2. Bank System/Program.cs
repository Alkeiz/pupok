using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = {
            new CheckingAccount("CHK001", "Иван Иванов", 50000, 100000),
            new SavingsAccount("SAV001", "Петр Петров", 5.0m, 50000),
            new CreditAccount("CRD001", "Сергей Сергеев", 100000, DateTime.Now.AddYears(1))
        };

            foreach (var account in accounts)
            {
                account.DisplayInfo();

                if (account is SavingsAccount savings)
                    savings.ApplyInterest();

                Console.WriteLine();
            }

            accounts[0].Withdraw(120000); // Использование овердрафта
            accounts[1].Deposit(10000);
            accounts[2].Withdraw(50000); // Использование кредита
        }
    }
}
