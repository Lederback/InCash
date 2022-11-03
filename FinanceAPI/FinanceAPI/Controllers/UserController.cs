using FinanceAPI.Data;
using FinanceAPI.Interfaces;
using FinanceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            var user = await _userService.GetAllUsers();

            if (user == null) return BadRequest("Nenhum usuário encontrado.");

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<Transaction>>> AddUser([FromBody] User user)
        {
            await _userService.AddUser(user);

            return Ok();
        }
    }
}
