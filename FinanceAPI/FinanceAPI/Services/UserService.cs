using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        private readonly ITransactionService _transactionService;

        public UserService(DataContext dataContext, ITransactionService transactionService)
        {
            _dataContext = dataContext;
            _transactionService = transactionService;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _dataContext.Users.Select(u => new User
                        {
                            Id = u.Id,
                            Login = u.Login,
                        }).ToListAsync();

            foreach (var u in users)
            {
                u.Transaction = await _transactionService.GetByUserId(u.Id);
            }

            if (users == null) return null;

            return users;
        }

        public async Task AddUser(User user)
        {
            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();
        }
    }
}
