using System;
namespace assignment9
{
    public class Bank
    {
        private BankAccount[] bankAccounts; // Array to hold bank accounts
        private int accountCount = 0; // Counter for the number of accounts

        // Constructor to initialize the bank with a given capacity
        public Bank(int capacity)
        {
            bankAccounts = new BankAccount[capacity]; // Initialize the array with the capacity
        }

        // Method to create a new bank account
        public void CreateAccount(string accountHolder)
        {
            // Create a new account with a default initial balance of 0 and an account number based on the current count
            BankAccount newAccount = new BankAccount(accountHolder, 0, accountCount + 1);
            bankAccounts[accountCount] = newAccount; // Add the new account to the array
            Console.WriteLine($"Account created with number: {newAccount.AccountNumber}");
            accountCount++; // Increment the account count

        }

        // Method to deposit money into a specific account
        public void Deposit(int accountNumber, double amount)
        {
            if (accountNumber > 0 && accountNumber <= accountCount) // Check if account number is valid
            {
                bankAccounts[accountNumber - 1].Deposit(amount); // Deposit into the correct account
                Console.WriteLine("Deposit successful.");
            }
        }

        // Method to withdraw money from a specific account
        public void Withdraw(int accountNumber, double amount)
        {
            if (accountNumber > 0 && accountNumber <= accountCount) // Check if account number is valid
            {
                bankAccounts[accountNumber - 1].Withdraw(amount); // Withdraw from the correct account
            }
            else
            {
                Console.WriteLine("Account not found."); // Handle invalid account number
            }
        }

        // Method to display account details for a specific account
        public void DisplayAccountDetails(int accountNumber)
        {
            if (accountNumber > 0 && accountNumber <= accountCount) // Check if account number is valid
            {
                BankAccount account = bankAccounts[accountNumber - 1]; // Get the correct account
                Console.WriteLine("Account Details:");
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Account Holder: {account.HolderName}");
                Console.WriteLine($"Balance: {account.Balance}");
            }
        }
    }
}
