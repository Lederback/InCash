using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly ITransactionService _transaction;

        public TransactionController(DataContext dataContext, ITransactionService transaction)
        {
            _dataContext = dataContext;
            _transaction = transaction;
        }

        [HttpGet]
        public async Task<ActionResult<List<Transaction>>> Get()
        {
            var transactions = await _transaction.GetAllTransactions();

            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Transaction>>> GetByUserId(int id)
        {
            var transaction = await _transaction.GetByUserId(id);

            if (transaction == null)
            {
                return BadRequest("Transaction not found.");
            }

            return Ok(transaction);
        }
        
        [HttpGet("{id}/{date}")]
        public async Task<ActionResult<List<Transaction>>> GetByDate(int id, DateTime date)
        {
            var transaction = await _transaction.GetByDate(id, date);

            if (transaction == null)
            {
                return BadRequest("Transaction not found.");
            }

            return Ok(transaction);
        }

        [HttpPost]
        public async Task<ActionResult<List<Transaction>>> AddTransaction([FromBody]Transaction transaction)
        {
            await _transaction.AddTransaction(transaction);

            return Ok();
        }

        //[HttpPut]
        //public async Task<ActionResult<List<Transaction>>> UpdateTransaction(Transaction request)
        //{
        //    var dbTransaction = await _dataContext.Transactions.FindAsync(request.Id);

        //    if (dbTransaction == null)
        //    {
        //        return BadRequest("Transaction not found.");
        //    }

        //    dbTransaction.Value = request.Value;
        //    dbTransaction.Description = request.Description;
        //    dbTransaction.Date = request.Date;
        //    dbTransaction.TypeTransaction = request.TypeTransaction;

        //    await _dataContext.SaveChangesAsync();

        //    return Ok(await _dataContext.Transactions.ToListAsync());
        //}

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Transaction>>> DeleteTransaction(int id)
        {
            await _transaction.DeleteTransaction(id);

            return Ok();
        }
    }
}
