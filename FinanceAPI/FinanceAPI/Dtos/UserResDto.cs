using FinanceAPI.Models;

namespace FinanceAPI.Dtos
{
    public class UserResDto
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public List<TransactionResDto>? Transactions { get; set; }
    }
}
