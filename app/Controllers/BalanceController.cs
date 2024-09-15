using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClickableGameBackend.Data;
using ClickableGameBackend.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using ClickableGameBackend.Dtos;

namespace ClickableGameBackend.Controllers {
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BalanceController : ControllerBase 
    {
        private readonly DataContext _context;

        public BalanceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<UserBalanceDto>> GetBalance()
        {
            var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (usernameClaim == null)
            {
                return Unauthorized("Username not found in token.");
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == usernameClaim.Value);

            if (user == null)
            {
                return NotFound("User not found."+ usernameClaim.Value);
            }

            var userBalance = await _context.UserBalances.FirstOrDefaultAsync(b => b.UserId == user.Id);

            if (userBalance == null)
            {
                return NotFound("User balance not found.");
            }

            var userBalanceDto = new UserBalanceDto
            {
                Balance = userBalance.Balance
            };

            return Ok(userBalanceDto);
        }

        // POST: api/Balance/AddFunds
        [HttpPost("AddFunds")]
        public async Task<ActionResult<UserBalanceDto>> AddFunds(decimal amount)
        {
            var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (usernameClaim == null)
            {
                return Unauthorized("Username not found in token.");
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == usernameClaim.Value);

            if (user == null)
            {
                return NotFound("User not found."+ usernameClaim.Value);
            }

            var userBalance = await _context.UserBalances.FirstOrDefaultAsync(b => b.UserId == user.Id);

            if (userBalance == null)
            {
                return NotFound("User balance not found.");
            }

            // Add the amount to the user's balance
            userBalance.Balance += amount;

            var userBalanceDto = new UserBalanceDto
            {
                Balance = userBalance.Balance
            };
            await _context.SaveChangesAsync();

            return Ok(userBalanceDto);
        }
    }
}