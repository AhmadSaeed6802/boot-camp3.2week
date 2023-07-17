using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{

    // Interface for transactions
    public interface ITransaction
    {
        void ExecuteTransactionTo(decimal amount);
        void ExecuteTransactionFrom(decimal amount);
        void PrintTransaction();
    }
}
