#nullable enable

using System.Collections.Generic;
using ClickableGameBackend.Models;

namespace ClickableGameBackend.Dtos {
    public class UserItemDto 
    {
        public ICollection<ItemDto>? Items { get; set; } = new List<ItemDto>();
    }
}

#nullable disable
