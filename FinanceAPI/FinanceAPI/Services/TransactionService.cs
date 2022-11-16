using FinanceAPI.Dtos;
using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceAPI.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly DataContext _dataContext;

        public TransactionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<TransactionResDto>> GetAllTransactions()
        {
            var transactions = await _dataContext.Transactions.Select(t => new TransactionResDto
            {
                Id = t.Id,
                Date = t.Date,
                Value = t.Value,
                Description = t.Description,
                TypeTransaction = t.TypeTransaction,
                UserId = t.UserId
            }).ToListAsync();

            if (transactions == null) return null;

            return transactions;
        }

        public async Task<List<TransactionResDto>> GetByUserId(int id)
        {
            var transaction = await _dataContext.Transactions.Where(t => t.UserId == id)
                           .Select(t => new TransactionResDto
                           {
                               Id = t.Id,
                               Date = t.Date,
                               Value = t.Value,
                               Description = t.Description,
                               TypeTransaction = t.TypeTransaction,
                               UserId = t.UserId,
                           }).ToListAsync();

            return transaction;
        }

        public async Task<List<TransactionResDto>> GetByDate(int id, DateTime date)
        {
            var transaction = await _dataContext.Transactions.Where(t => t.UserId == id && t.Date.Month == date.Month && t.Date.Year == date.Year)
                           .Select(t => new TransactionResDto
                           {
                               Id = t.Id,
                               Date = t.Date,
                               Value = t.Value,
                               Description = t.Description,
                               TypeTransaction = t.TypeTransaction,
                               UserId = t.UserId,
                           }).ToListAsync();

            return transaction;
        }

        public async Task AddTransaction(TransactionReqDto request)
        {
            Transaction transaction = new Transaction()
            {
                Date = request.Date,
                Value = request.Value,
                Description = request.Description,
                TypeTransaction = request.TypeTransaction,
                UserId = request.UserId,
            };

            _dataContext.Transactions.Add(transaction);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteTransaction(int id)
        {
            var dbTransaction = await _dataContext.Transactions.FindAsync(id);

            if (dbTransaction == null)
            {
                return;
            }

            _dataContext.Transactions.Remove(dbTransaction);

            await _dataContext.SaveChangesAsync();
        }
    }
}