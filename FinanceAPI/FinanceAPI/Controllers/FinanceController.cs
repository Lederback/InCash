using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private static List<Transaction> transaction = new List<Transaction>
        {
            new Transaction
            {
                Id = 1,
                Date = DateTime.Now,
                Description = "Compra de açaí",
                Value = 10.0M,
                TypeTransaction = Transaction.TypeEnum.Lazer,
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<Transaction>>> Get()
        {
            return Ok(transaction);
        }
    }
}
