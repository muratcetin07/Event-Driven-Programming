using EventDrivenProgramming.Abstract;
using EventDrivenProgramming.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramming.Concrete
{
    public class AuditService : IAuditService
    {
        public void Subscribe(ITransactionService transactionService)
        {
            transactionService.OnTransactionProcessed += WriteAuditLog;
        }

        private void WriteAuditLog(object sender, TransactionProcessedEventArgs e)
        {
            Console.WriteLine($"AUDIT LOG: {e.TransactionType} for ${e.Amount} processed");
        }
    }
}
