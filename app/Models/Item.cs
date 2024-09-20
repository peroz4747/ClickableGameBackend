using System;
using System.Collections.Generic;

#nullable enable

namespace ClickableGameBackend.Models {
    public class Item
    {
        public required int Id { get; set; }
        public required string? Name { get; set; }

        public required decimal Power { get; set; }
        public required decimal Price { get; set; }
        public required string ImageUrl { get; set; }

        public  ICollection<Transaction>? Transactions { get; set; }
    }

}

#nullable disable