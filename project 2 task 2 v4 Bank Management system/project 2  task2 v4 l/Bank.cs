using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    // Bank class represents a bank that manages different bank accounts.
    public class Bank
    {
        private Dictionary<string, BankAccount> accounts; // Dictionary to store bank accounts

        public Bank()
        {
            accounts = new Dictionary<string, BankAccount>();
        }

        // Method to add a bank account to the bank
        public void AddAccount(BankAccount account)
        {
            accounts.Add(account.AccountNumber, account);
        }

        // Method to remove a bank account from the bank
        public void RemoveAccount(BankAccount account)
        {
            accounts.Remove(account.AccountNumber);
        }

        // Method to get a bank account by account number
        public BankAccount GetAccount(string accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                return accounts[accountNumber];
            }
            else
            {
                return null;
            }
        }
    }
}

