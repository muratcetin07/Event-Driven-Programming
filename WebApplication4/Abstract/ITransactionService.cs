using EventDrivenProgramming.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramming.Abstract
{
    public interface ITransactionService
    {
        void MakeDeposit(decimal amount);
        void MakeWithdrawal(decimal amount);
        event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;
    }
}
