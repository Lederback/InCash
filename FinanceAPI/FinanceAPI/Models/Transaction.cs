using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }
        public TypeOfTransaction TypeTransaction { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
