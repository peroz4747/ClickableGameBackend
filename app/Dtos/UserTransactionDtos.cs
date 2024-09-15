#nullable enable

using System.Collections.Generic;
using ClickableGameBackend.Models;

namespace ClickableGameBackend.Dtos {
    public class UserTransactionDto 
    {
        public decimal Balance { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}

#nullable disable
