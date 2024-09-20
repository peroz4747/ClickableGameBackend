using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClickableGameBackend.Data;
using ClickableGameBackend.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using ClickableGameBackend.Dtos;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Components.Web;
using System;

namespace ClickableGameBackend.Controllers {
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase 
    {
        private readonly DataContext _context;

        public TransactionController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<UserTransactionDto>> GetUserTransactions()
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

            var userTrasactionDto = new UserTransactionDto
            {
                Balance = userBalance.Balance,
                Transactions = await _context.Transactions
                    .Where(t => t.UserId == user.Id)
                    .ToListAsync()
            };

            return Ok(userTrasactionDto);
        }

        [HttpPost("Buy")]
        public async Task<ActionResult<UserTransactionDto>> BuyItem(int ItemId)
        {
            var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (usernameClaim == null)
            {
                return Unauthorized("Username not found in token.");
            }

            var user = await _context.Users
                .Include(u => u.Transactions)
                .Include(u => u.UserItems)
                .FirstOrDefaultAsync(u => u.Username == usernameClaim.Value);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            var userBalance = await _context.UserBalances.FirstOrDefaultAsync(b => b.UserId == user.Id);

            if (userBalance == null)
            {
                return NotFound("User balance not found.");
            }

            var item = await _context.Items.FirstOrDefaultAsync(i => i.Id == ItemId);

            if (item == null)
            {
                return NotFound("Item not found.");
            }

            if (item.Price > userBalance.Balance)
            {
                return BadRequest("Not enough balance.");
            }

            // Check if the UserItem already exists (i.e., user already owns the item)
            var existingUserItem = await _context.UserItems
                .FirstOrDefaultAsync(ui => ui.UserId == user.Id && ui.ItemId == item.Id);

            if (existingUserItem != null)
            {
                // Update the existing UserItem (e.g., increase the Count or handle it accordingly)
                existingUserItem.Count += 1; // Adjust the count as needed
            }
            else
            {
                // If the UserItem does not exist, add a new one
                var newUserItem = new UserItem
                {
                    UserId = user.Id,
                    ItemId = item.Id,
                    Name = item.Name,
                    Power = item.Power,
                    Count = 1 // Starting with 1, or adjust based on logic
                };

                _context.UserItems.Add(newUserItem);
            }

            // Create a new transaction
            var transaction = new Transaction
            {
                UserId = user.Id,
                ItemId = item.Id,
                Amount = item.Price,
                TransactionDate = DateTime.UtcNow,
                TransactionType = "Purchase"
            };

            _context.Transactions.Add(transaction);  // Add transaction

            // Deduct from the user's balance
            userBalance.Balance -= item.Price;

            await _context.SaveChangesAsync();  // Save changes

            // Return updated balance and transaction list
            var userTransactionDto = new UserTransactionDto
            {
                Balance = userBalance.Balance,
                Transactions = await _context.Transactions
                    .Where(t => t.UserId == user.Id)
                    .ToListAsync()
            };

            return Ok(userTransactionDto);
        }

    }
}