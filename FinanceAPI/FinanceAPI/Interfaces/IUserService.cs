using FinanceAPI.Dtos;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Interfaces
{
    public interface IUserService
    {
        Task<List<UserResDto>> GetAllUsers();
        Task AddUser(UserReqDto user);
        Task<string> UserLogin(UserReqDto request);
    }
}
