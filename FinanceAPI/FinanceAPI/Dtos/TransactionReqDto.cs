using FinanceAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceAPI.Dtos
{
    public class TransactionReqDto
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }
        public TypeOfTransaction TypeTransaction { get; set; }
        public int UserId { get; set; }
    }
}
