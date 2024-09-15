using System;
using System.Collections.Generic;

#nullable enable

namespace ClickableGameBackend.Models {
    public class User 
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public UserBalance? UserBalance { get; set; }
        public ICollection<Transaction>? Transactions { get; set; } = new List<Transaction>();
        public ICollection<UserItem>? UserItems { get; set; } = new List<UserItem>();
    }
}

#nullable disable