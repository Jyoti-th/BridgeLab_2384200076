using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
// Custom Exception for Insufficient Funds
class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    // BankAccount Class
    class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount! Amount cannot be negative.");
            }
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            balance -= amount;
            Console.WriteLine($"Withdrawal successful, new balance: {balance}");
        }
    }

    // Main Program
    class Bank
    {
        public static void BankTransaction()
        {
            // Initializing account with balance
            BankAccount account = new BankAccount(5000);

            try
            {
                // Taking user input for withdrawal amount
                Console.Write("Enter withdrawal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                // Performing withdrawal
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numeric amount.");
            }
        }
    
}
}
