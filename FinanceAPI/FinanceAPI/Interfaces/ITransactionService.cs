using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Interfaces
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetAllTransactions();
        Task<List<Transaction>> GetByUserId(int id);
        Task<List<Transaction>> GetByDate(int id, DateTime date);
        Task AddTransaction(Transaction transaction);
        Task DeleteTransaction(int id);
    }
}
