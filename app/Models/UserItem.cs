using System;
using System.Collections.Generic;

#nullable enable

namespace ClickableGameBackend.Models {
    public class UserItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public decimal Power { get; set; }
        public string? Name { get; set; }
        public int Count { get; set; }
    }

}

#nullable disable