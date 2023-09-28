using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Ques2
    {
        public delegate void BalanceChangedEventHandler(decimal newBalance);
        public class Account
        {
            private decimal balance;

            public event BalanceChangedEventHandler BalanceChanged;

            public decimal Balance
            {
                get => balance;
                set
                {
                    balance = value;
                    OnBalanceChanged(balance);
                }
            }

            protected virtual void OnBalanceChanged(decimal newBalance)
            {
                BalanceChanged?.Invoke(newBalance);
            }
        }

        class Program
        {
            static void HandleBalanceChanged(decimal newBalance)
            {
                Console.WriteLine($"New account balance: {newBalance}");
            }

            static void Main(string[] args)
            {
                Account userAccount = new Account();

                userAccount.BalanceChanged += HandleBalanceChanged;

                userAccount.Balance = 1000.0m; // Initial balance
                userAccount.Balance = 1500.0m; // After a deposit
                userAccount.Balance = 800.0m;  // After a withdrawal

                userAccount.BalanceChanged -= HandleBalanceChanged;

                userAccount.Balance = 2000.0m; // No notification
            }
        }

    }
}

