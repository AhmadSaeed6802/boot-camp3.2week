using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    // CheckingAccount class represents a checking account and inherits from BankAccount class.
    public class CheckingAccount : BankAccount, ITransaction
    {
        public CheckingAccount(string accountNumber, string accountHolderName)
            : base(accountNumber, accountHolderName)
        {
        }

        public override decimal CalculateInterest()
        {
            decimal interestRate = 0.03m;
            return Balance * interestRate;
        }

        public void ExecuteTransactionTo(decimal amount)
        {
            Deposit(amount);
        }
        public void ExecuteTransactionFrom(decimal amount)
        {
            Withdraw(amount);
        }

        public void PrintTransaction()
        {
            Console.WriteLine("Transaction Executed: Deposit");
        }
    }
}
