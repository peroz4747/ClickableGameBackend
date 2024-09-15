using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ClickableGameBackend.Data;
using ClickableGameBackend.Dtos;
using ClickableGameBackend.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace ClickableGameBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            if (userDto.Username == null || userDto.Password == null)
            {
                return BadRequest("Username and Password are required.");
            }

            if (await UserExists(userDto.Username))
                return BadRequest("User already exists");

            CreatePasswordHash(userDto.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var user = new User
            {
                Username = userDto.Username,
                PasswordHash = Convert.ToBase64String(passwordHash),
                PasswordSalt = Convert.ToBase64String(passwordSalt)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var userBalance = new UserBalance
            {
                UserId = user.Id,
                Balance = 0
            };

            _context.UserBalances.Add(userBalance);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            if (userDto.Username == null || userDto.Password == null)
            {
                return BadRequest("Username and Password are required.");
            }

            var user = await _context.Users.SingleOrDefaultAsync(x => x.Username == userDto.Username);
            if (user == null)
                return Unauthorized("Invalid username or password");

            if (user.PasswordHash == null || user.PasswordSalt == null)
            {
                return Unauthorized("Invalid username or password");
            }

            if (!VerifyPasswordHash(userDto.Password, Convert.FromBase64String(user.PasswordHash), Convert.FromBase64String(user.PasswordSalt)))
                return Unauthorized("Invalid username or password");

            var token = CreateToken(user);

            return Ok(new { token });
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(storedHash);
            }
        }
        private string CreateToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.Username)
            };

            var keyString = _configuration["Jwt:Key"];
            if (string.IsNullOrEmpty(keyString) || keyString.Length < 16)
            {
                throw new InvalidOperationException("JWT key must be at least 128 bits (16 characters) long.");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var expireMinutes = _configuration["Jwt:ExpireMinutes"];
            double expireMinutesDouble = 60; // default to 60 minutes
            if (!string.IsNullOrEmpty(expireMinutes) && !double.TryParse(expireMinutes, out expireMinutesDouble))
            {
                expireMinutesDouble = 60;
            }

            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            if (string.IsNullOrEmpty(issuer) || string.IsNullOrEmpty(audience))
            {
                throw new InvalidOperationException("JWT issuer or audience not found.");
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(expireMinutesDouble),
                SigningCredentials = creds,
                Issuer = issuer,
                Audience = audience
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username != null && x.Username.ToLower() == username.ToLower());
        }
    }
}
