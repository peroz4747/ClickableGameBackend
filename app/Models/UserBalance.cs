using System;

#nullable enable

namespace ClickableGameBackend.Models {
    public class UserBalance 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Balance { get; set; } = 0;

        public User? User { get; set; }
    }
}

#nullable disable