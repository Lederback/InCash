using FinanceAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceAPI.Dtos
{
    public class TransactionResDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }
        public TypeOfTransaction TypeTransaction { get; set; }
        public int UserId { get; set; }
    }
}
