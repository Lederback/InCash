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

        public TransactionController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Transaction>>> Get()
        {
            return Ok(await _dataContext.Transactions.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Transaction>>> Get(int id)
        {
            var transaction = await _dataContext.Transactions.FindAsync(id);

            if (transaction == null)
            {
                return BadRequest("Transaction not found.");
            }

            return Ok(transaction);
        }

        [HttpPost]
        public async Task<ActionResult<List<Transaction>>> AddTransaction([FromBody]Transaction transaction)
        {
            _dataContext.Transactions.Add(transaction);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Transactions.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Transaction>>> UpdateTransaction(Transaction request)
        {
            var dbTransaction = await _dataContext.Transactions.FindAsync(request.Id);

            if (dbTransaction == null)
            {
                return BadRequest("Transaction not found.");
            }

            dbTransaction.Value = request.Value;
            dbTransaction.Description = request.Description;
            dbTransaction.Date = request.Date;
            dbTransaction.TypeTransaction = request.TypeTransaction;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Transactions.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Transaction>>> DeleteTransaction(int id)
        {
            var dbTransaction = await _dataContext.Transactions.FindAsync(id);

            if (dbTransaction == null)
            {
                return BadRequest("Transaction not found.");
            }

            _dataContext.Transactions.Remove(dbTransaction);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Transactions.ToListAsync());
        }
    }
}
