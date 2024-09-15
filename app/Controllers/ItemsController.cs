using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClickableGameBackend.Data;
using ClickableGameBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ClickableGameBackend.Dtos;


namespace ClickableGameBackend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly DataContext _context;

        public ItemsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        [HttpGet("user")]
        public async Task<ActionResult<UserItemDto>> GetUserItems()
        {
            var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (usernameClaim == null)
            {
                return Unauthorized("Username not found in token.");
            }

            var user = await _context.Users
                .Include(u => u.UserItems) // Include UserItems to retrieve the user's items // Also include the actual Item entity in the join table
                .FirstOrDefaultAsync(u => u.Username == usernameClaim.Value);

            if (user == null)
            {
                return NotFound("User not found: " + usernameClaim.Value);
            }

            // Create a DTO that includes the relevant items for the user
            var userItemDto = new UserItemDto
            {
                Items = user.UserItems.Select(ui => new ItemDto
                {
                    Id = ui.ItemId,
                    Name = ui.Name,
                    Count = ui.Count
                }).ToList()
            };

            return Ok(userItemDto);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
