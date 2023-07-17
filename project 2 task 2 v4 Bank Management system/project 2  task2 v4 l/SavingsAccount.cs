using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    // SavingsAccount class represents a savings account and inherits from BankAccount class.
    public class SavingsAccount : BankAccount, ITransaction
    {
        public SavingsAccount(string accountNumber, string accountHolderName)
            : base(accountNumber, accountHolderName)
        {
        }

        public override decimal CalculateInterest()
        {
            decimal interestRate = 0.06m;
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
