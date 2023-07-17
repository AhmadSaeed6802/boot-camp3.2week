using System;
using System.Collections.Generic;
namespace BankAccountManagementSystem
    {

        class Program
        {
            static void Main(string[] args)
            {
                // Create a bank
                Bank bank = new Bank();

                // Create and add bank accounts
                SavingsAccount savingsAccount = new SavingsAccount("SA001", "Baber");
                bank.AddAccount(savingsAccount);

                CheckingAccount checkingAccount = new CheckingAccount("CA001", "Hamza ali");
                bank.AddAccount(checkingAccount);

                LoanAccount loanAccount = new LoanAccount("LA001", "Ali");
                bank.AddAccount(loanAccount);

                // Perform transactions
                savingsAccount.ExecuteTransactionTo(1000);
                savingsAccount.ExecuteTransactionFrom(500);

                checkingAccount.ExecuteTransactionTo(2000);
                checkingAccount.ExecuteTransactionFrom(1000);

                loanAccount.ExecuteTransactionTo(5000);

                // Display account information and transaction history
                savingsAccount.DisplayAccountInfo();
                savingsAccount.DisplayTransactionHistory();

                checkingAccount.DisplayAccountInfo();
                checkingAccount.DisplayTransactionHistory();

                loanAccount.DisplayAccountInfo();
                loanAccount.DisplayTransactionHistory();

                Console.ReadLine();
            }
        }
    }

