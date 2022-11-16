using FinanceAPI.Dtos;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Interfaces
{
    public interface ITransactionService
    {
        Task<List<TransactionResDto>> GetAllTransactions();
        Task<List<TransactionResDto>> GetByUserId(int id);
        Task<List<TransactionResDto>> GetByDate(int id, DateTime date);
        Task AddTransaction(TransactionReqDto transaction);
        Task DeleteTransaction(int id);
    }
}
