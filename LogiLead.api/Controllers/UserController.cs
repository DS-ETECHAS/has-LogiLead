using LogiLead.api.Data;
using LogiLead.api.Models;
using LogiLead.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogiLead.api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly LogiLeadContext _context;
        private readonly HashService _hashService;
        public UserController(LogiLeadContext context, HashService hashService)
        {
            _context = context;
            _hashService = hashService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserRegisterDto userInput)
        {
            User user = new User
            {
                Name = userInput.Name,
            };

            UserData userData = new UserData
            {
                HashedPassword = _hashService.HashPassword(userInput.Password),
                User = user,
                Email = userInput.Email
            };
            await _context.Users.AddAsync(user);
            await _context.UserDatas.AddAsync(userData);

            await _context.SaveChangesAsync();
            
            return Created("User", user.Name);
        }
    }
}
