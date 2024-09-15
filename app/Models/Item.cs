using System;
using System.Collections.Generic;

#nullable enable

namespace ClickableGameBackend.Models {
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public  ICollection<Transaction>? Transactions { get; set; }
    }

}

#nullable disable