using System;
using System.Collections.Generic;

namespace OOPs_Object_Modeling
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; private set; } = new List<Customer>();

        public Bank(string name)
        {
            Name = name;
        }

        // Method to open an account for a customer
        public void OpenAccount(Customer customer, string accountType, decimal initialDeposit)
        {
            BankAccount newAccount = new BankAccount(accountType, initialDeposit, this);
            customer.AddAccount(newAccount);
            if (!Customers.Contains(customer))
            {
                Customers.Add(customer);
            }
            Console.WriteLine($"Account opened for {customer.Name} at {Name} with balance {initialDeposit:C}");
        }
    }

    // Represents a customer who owns bank accounts
    public class Customer
    {
        public string Name { get; set; }
        private List<BankAccount> Accounts = new List<BankAccount>();

        public Customer(string name)
        {
            Name = name;
        }

        // Adds a bank account to the customer's account list
        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
        }

        // Displays all account balances
        public void ViewBalance()
        {
            Console.WriteLine($"{Name}'s Account Balances:");
            foreach (var account in Accounts)
            {
                Console.WriteLine($"- {account.AccountType}: {account.Balance:C} at {account.Bank.Name}");
            }
        }
    }

    // Represents a bank account owned by a customer
    public class BankAccount
    {
        public string AccountType { get; set; }
        public decimal Balance { get; private set; }
        public Bank Bank { get; private set; }

        public BankAccount(string accountType, decimal initialDeposit, Bank bank)
        {
            if (initialDeposit < 0)
                throw new ArgumentException("Initial deposit cannot be negative.");

            AccountType = accountType;
            Balance = initialDeposit;
            Bank = bank;
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} into {AccountType} account. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
    }

    
}
