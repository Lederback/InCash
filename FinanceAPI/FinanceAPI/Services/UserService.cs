using FinanceAPI.Dtos;
using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.SymbolStore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace FinanceAPI.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        private readonly ITransactionService _transactionService;
        private readonly IConfiguration _configuration;

        public UserService(DataContext dataContext, ITransactionService transactionService, IConfiguration configuration)
        {
            _dataContext = dataContext;
            _transactionService = transactionService;
            _configuration = configuration; 
        }

        public async Task<List<UserResDto>> GetAllUsers()
        {
            var users = await _dataContext.Users.Select(u => new UserResDto
            {
                Id = u.Id,
                Login = u.Login,
            }).ToListAsync();

            foreach (var u in users)
            {
                u.Transactions = await _transactionService.GetByUserId(u.Id);
            }

            if (users == null) return null;

            return users;
        }

        public async Task AddUser(UserReqDto request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            User user = new User();

            user.Login = request.Login;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<string> UserLogin(UserReqDto request)
        {
            var user = await _dataContext.Users.Where(u => u.Login == request.Login).FirstOrDefaultAsync();

            if (user == null) return "";

            if (!VerifyPasswordHash(request.Password, user)) return "";

            string token = CreateToken(user);

            return token;
        }

        private bool VerifyPasswordHash(string password, User user)
        {
            using (var hmac = new HMACSHA512(user.PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                return computedHash.SequenceEqual(user.PasswordHash);
            }
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Login)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(100),
                signingCredentials: cred);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
