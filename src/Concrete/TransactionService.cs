using EventDrivenProgramming.Abstract;
using EventDrivenProgramming.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramming.Concrete
{
    public class TransactionService : ITransactionService
    {
        public event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;

        public void MakeDeposit(decimal amount)
        {
            ProcessDeposit(amount);
            if(OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, Constants.TransactionType.Deposit));
            }
        }

        public void MakeWithdrawal(decimal amount)
        {
            ProcessWithdrawal(amount);
            if (OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, Constants.TransactionType.Withdrawal));
            }
        }

        private void ProcessDeposit(decimal amount)
        {
            // Processing logic here
        }

        private void ProcessWithdrawal(decimal amount)
        {
            // Processing logic here
        }
    }
}
