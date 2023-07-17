using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    // LoanAccount class represents a loan account and inherits from BankAccount class.
    public class LoanAccount : BankAccount, ITransaction
    {
        public LoanAccount(string accountNumber, string accountHolderName)
            : base(accountNumber, accountHolderName)
        {
        }

        public override decimal CalculateInterest()
        {
            decimal interestRate = 0.09m;
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
