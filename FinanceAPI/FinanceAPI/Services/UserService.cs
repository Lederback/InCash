using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _dataContext.Users.ToListAsync();

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
