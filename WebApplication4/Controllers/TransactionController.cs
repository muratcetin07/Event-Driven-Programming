using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventDrivenProgramming.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EventDrivenProgramming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionService TransactionService;
        private IAuditService AuditService;
            
        public TransactionController(ITransactionService transactionService, IAuditService auditService)
        {
            TransactionService = transactionService;
            AuditService = auditService;
            AuditService.Subscribe(TransactionService);
        }

        [HttpPost("makeDeposit")]
        public IActionResult MakeDeposit([FromQuery]decimal amount)
        {
            TransactionService.MakeDeposit(amount);
            return Ok();
        }

        [HttpPost("makeWithdrawal")]
        public IActionResult MakeWithdrawal([FromQuery]decimal amount)
        {
            TransactionService.MakeWithdrawal(amount);
            return Ok();
        }
    }
}
