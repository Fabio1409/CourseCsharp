﻿
using System.Collections.Generic;
using ClassesAbstratas.Entities;
using System.Globalization;

namespace ClassesAbstratas
{
    class Program
    {
        public static void  Main(string[] args)
        {
            Account aca = new Account();
            List<Account> list = new List<Account>();// Posso usar a classe em lista,instanciar nao posso

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("f2", CultureInfo.InvariantCulture));

            foreach (Account account in list)
            {
                account.Withdraw(10.0);
            }
            foreach (Account account in list)
            {
                Console.WriteLine("Update balance for account:"
                    + account.Number
                    + ": "
                    + account.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }

        }
    }
}