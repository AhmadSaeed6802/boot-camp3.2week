using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    // Transaction class represents a single transaction with its type and amount.
    public class Transaction
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public Transaction(string type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Amount: Rs:{Amount}";
        }
    }
}
