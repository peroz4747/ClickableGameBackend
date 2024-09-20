#nullable enable

namespace ClickableGameBackend.Dtos {
    public class ItemDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Power { get; set; }
        public int Count { get; set; }  // Assuming the count of each item a user has
    }
}

#nullable disable


