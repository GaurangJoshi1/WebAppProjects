using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P15_BankAccount
    {
        private string accountNumber;
        private double balance;

        public P15_BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public void Deposite(double amount)
        {
            Console.WriteLine(" P15 : simulates a bank account. Handle exceptions for scenarios like insufficient \r\nfunds when withdrawing money and invalid account numbers.");
            Console.WriteLine();
            if(amount <= 0) 
            {
                throw new ArgumentException("Deposite amount must be graeter than zero");
            }
            balance += amount;
            Console.WriteLine("Deposite : " + amount + "  New Balance : " + balance);
            Console.WriteLine();
        }
        public void Withdraw(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero");
            }

            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            balance -= amount;
            Console.WriteLine("Withdraw : " + amount + "  New Balance : " + balance);
            Console.WriteLine();
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
