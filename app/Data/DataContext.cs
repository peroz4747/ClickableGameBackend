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
                new Item { Id = 1, Name = "Tank", Price = 100000m },
                new Item { Id = 2, Name = "Airplane", Price = 10000000m },
                new Item { Id = 3, Name = "Ship", Price = 1000000m }
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