using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(1000);
            BankAccount account2 = new BankAccount(500);

            Console.WriteLine($"Баланс до перевода: Счёт 1 = {account1.GetBalance()}$, Счёт 2 = {account2.GetBalance()}$");
            account1.Transfer(300, account2);
            Console.WriteLine($"Баланс после перевода: Счёт 1 = {account1.GetBalance()}$, Счёт 2 = {account2.GetBalance()}$");

            Console.ReadLine();
        }
    }
}
