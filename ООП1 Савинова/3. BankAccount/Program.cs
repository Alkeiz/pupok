using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ummm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Мафусаил";
            bankAccount.Balance = 500.5;
            double balance = bankAccount.Balance;
            bankAccount.Deposit(bankAccount.Owner, bankAccount.Balance);
            bankAccount.Withdraf(bankAccount.Owner, bankAccount.Balance);
            Console.ReadKey();
        }
    }
}
