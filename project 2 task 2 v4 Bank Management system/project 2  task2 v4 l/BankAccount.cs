using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    // BankAccount class represents an abstraction of a bank account.
    // It encapsulates the basic properties of a bank account.
    public abstract class BankAccount
    {
        // Private data members
        private string accountNumber;
        private string accountHolderName;
        private decimal balance;
        private List<Transaction> transactions; // List to store transaction history

        // Public properties for encapsulation
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Constructor
        public BankAccount(string accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = 0;
            this.transactions = new List<Transaction>();
        }

        // Method to deposit money into the account
        public virtual void Deposit(decimal amount)
        {
            balance += amount;

            // Add the deposit transaction to the transaction history
            transactions.Add(new Transaction("Deposit", amount));
        }

        // Method to withdraw money from the account
        public virtual void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;

                // Add the withdrawal transaction to the transaction history
                transactions.Add(new Transaction("Withdrawal", amount));
            }
            else
            {
                Console.WriteLine("Insufficient funds in the account.");
            }
        }

        // Method to calculate interest (to be overridden by subclasses)
        public abstract decimal CalculateInterest();

        // Method to display the account information
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
            Console.WriteLine("Balance: Rs" + balance);
        }

        // Method to display the transaction history
        public void DisplayTransactionHistory()
        {
            Console.WriteLine("Transaction History:");

            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }
    }
}
