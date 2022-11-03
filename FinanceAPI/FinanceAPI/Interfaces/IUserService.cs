using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Interfaces
{
    public interface IUserService
    {
        Task<ActionResult<List<User>>> GetAllUsers();
        Task AddUser(User user);
    }
}
