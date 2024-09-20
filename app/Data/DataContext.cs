using Microsoft.EntityFrameworkCore;
using ClickableGameBackend.Models;

namespace ClickableGameBackend.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<UserBalance> UserBalances { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserItem> UserItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "M16 Rifle", Power = 30, Price = 1200m },
                new Item { Id = 2, Name = "AK-47", Power = 35, Price = 700m },
                new Item { Id = 3, Name = "HK416", Power = 38, Price = 2500m },
                new Item { Id = 4, Name = "FN SCAR", Power = 40, Price = 3000m },
                new Item { Id = 5, Name = "Barrett M82", Power = 50, Price = 10000m },
                new Item { Id = 6, Name = "RPG-7", Power = 45, Price = 1200m },
                new Item { Id = 7, Name = "M4 Carbine", Power = 35, Price = 1500m },
                new Item { Id = 8, Name = "FN F2000", Power = 38, Price = 2300m },
                new Item { Id = 9, Name = "IWI Tavor", Power = 40, Price = 2800m },
                new Item { Id = 10, Name = "CZ BREN 2", Power = 38, Price = 2200m },
                new Item { Id = 11, Name = "M2 Browning", Power = 50, Price = 12000m },
                new Item { Id = 12, Name = "Desert Eagle", Power = 25, Price = 1800m },
                new Item { Id = 13, Name = "Glock 17", Power = 20, Price = 600m },
                new Item { Id = 14, Name = "Colt M1911", Power = 22, Price = 800m },
                new Item { Id = 15, Name = "M1 Abrams", Power = 90, Price = 7000000m },
                new Item { Id = 16, Name = "Leopard 2A7", Power = 92, Price = 8000000m },
                new Item { Id = 17, Name = "T-90", Power = 85, Price = 4000000m },
                new Item { Id = 18, Name = "Challenger 2", Power = 88, Price = 6000000m },
                new Item { Id = 19, Name = "Merkava Mk IV", Power = 85, Price = 6500000m },
                new Item { Id = 20, Name = "Type 99", Power = 84, Price = 5000000m },
                new Item { Id = 21, Name = "Leclerc", Power = 87, Price = 9000000m },
                new Item { Id = 22, Name = "K2 Black Panther", Power = 90, Price = 8500000m },
                new Item { Id = 23, Name = "T-14 Armata", Power = 92, Price = 7500000m },
                new Item { Id = 24, Name = "AMX-56 Leclerc", Power = 88, Price = 8500000m },
                new Item { Id = 25, Name = "PT-91 Twardy", Power = 80, Price = 4500000m },
                new Item { Id = 26, Name = "F-35 Lightning II", Power = 95, Price = 100000000m },
                new Item { Id = 27, Name = "Sukhoi Su-57", Power = 90, Price = 90000000m },
                new Item { Id = 28, Name = "F-22 Raptor", Power = 98, Price = 120000000m },
                new Item { Id = 29, Name = "Eurofighter Typhoon", Power = 85, Price = 80000000m },
                new Item { Id = 30, Name = "Dassault Rafale", Power = 84, Price = 75000000m },
                new Item { Id = 31, Name = "J-20 Mighty Dragon", Power = 88, Price = 90000000m },
                new Item { Id = 32, Name = "Saab Gripen", Power = 80, Price = 60000000m },
                new Item { Id = 33, Name = "F/A-18 Super Hornet", Power = 87, Price = 75000000m },
                new Item { Id = 34, Name = "MiG-35", Power = 82, Price = 45000000m },
                new Item { Id = 35, Name = "F-16 Fighting Falcon", Power = 80, Price = 40000000m },
                new Item { Id = 36, Name = "F-15 Eagle", Power = 85, Price = 60000000m },
                new Item { Id = 37, Name = "Su-35 Flanker-E", Power = 85, Price = 50000000m },
                new Item { Id = 38, Name = "A-10 Thunderbolt II", Power = 70, Price = 18000000m },
                new Item { Id = 39, Name = "B-2 Spirit Bomber", Power = 98, Price = 1500000000m },
                new Item { Id = 40, Name = "B-52 Stratofortress", Power = 85, Price = 100000000m },
                new Item { Id = 41, Name = "Arleigh Burke Destroyer", Power = 80, Price = 1500000000m },
                new Item { Id = 42, Name = "Zumwalt-Class Destroyer", Power = 85, Price = 4000000000m },
                new Item { Id = 43, Name = "Nimitz-Class Aircraft Carrier", Power = 98, Price = 9000000000m },
                new Item { Id = 44, Name = "Ford-Class Aircraft Carrier", Power = 100, Price = 13000000000m },
                new Item { Id = 45, Name = "Queen Elizabeth-Class Carrier", Power = 95, Price = 6500000000m },
                new Item { Id = 46, Name = "Type 45 Destroyer", Power = 80, Price = 1200000000m },
                new Item { Id = 47, Name = "Admiral Gorshkov-Class Frigate", Power = 75, Price = 500000000m },
                new Item { Id = 48, Name = "LCS Freedom-Class", Power = 70, Price = 400000000m },
                new Item { Id = 49, Name = "Seawolf-Class Submarine", Power = 95, Price = 3000000000m },
                new Item { Id = 50, Name = "Virginia-Class Submarine", Power = 90, Price = 2700000000m }
            );


            // Define 1:1 relationship between User and UserBalance
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserBalance)
                .WithOne(b => b.User)
                .HasForeignKey<UserBalance>(b => b.UserId);

            // Define 1:N relationship between User and Transaction
            modelBuilder.Entity<Transaction>()
                .HasOne<User>()
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define 1:N relationship between Item and Transaction
            modelBuilder.Entity<Transaction>()
                .HasOne<Item>()
                .WithMany()
                .HasForeignKey(t => t.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // Define the many-to-many relationship via UserItem
            modelBuilder.Entity<UserItem>()
                .HasKey(ui => new { ui.UserId, ui.ItemId });  // Composite key

            modelBuilder.Entity<UserItem>()
                .HasOne<User>()
                .WithMany(u => u.UserItems)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<UserItem>()
                .HasOne<Item>()
                .WithMany()
                .HasForeignKey(ui => ui.ItemId);
        }
    }
}