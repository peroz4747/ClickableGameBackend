using System;

#nullable enable

namespace ClickableGameBackend.Models {
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
        public string? TransactionType { get; set; } = string.Empty;
    }
}

#nullable disable