using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenProgramming.Abstract
{
    public interface IAuditService
    {
        void Subscribe(ITransactionService transactionService);
    }
}
