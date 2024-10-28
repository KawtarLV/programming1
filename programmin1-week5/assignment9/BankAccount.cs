using System;
namespace assignment9
{
	public class BankAccount
	{
        public string HolderName { get; private set; } // The name of the account holder
        public double Balance { get; private set; } // The account balance
        public int AccountNumber { get; private set; } // The account number

        // Constructor to initialize the account
        public BankAccount(string holderName, double initialBalance, int accountNumber)
        {
            HolderName = holderName;
            Balance = initialBalance;
            AccountNumber = accountNumber;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            Balance += amount; // Increase the balance by the deposit amount
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            Balance -= amount; // Decrease the balance by the withdrawal amount
        }

    }
}

