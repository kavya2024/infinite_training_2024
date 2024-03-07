using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    class banking
    {
        private double balance;

        public banking(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be greater than zero.");
            }
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount should be greater than zero.");
            }

            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {balance:C}");
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write(" initial balance: ");
                double initialBalance = Convert.ToDouble(Console.ReadLine());

                banking myAccount = new banking(initialBalance);

                Console.Write("deposit amount: ");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                myAccount.Deposit(depositAmount);

                Console.Write("withdrawal amount: ");
                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                myAccount.Withdraw(withdrawalAmount);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient Balance Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}