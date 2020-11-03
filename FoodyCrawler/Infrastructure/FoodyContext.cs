using FoodyCrawler.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodyCrawler.Infrastructure
{
    public class FoodyContext : DbContext
    {
        public FoodyContext(DbContextOptions<FoodyContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");

            modelBuilder.Entity<Item>().ToTable("Item");

            modelBuilder.Entity<Photo>().ToTable("Photo");

            modelBuilder.Entity<Price>().ToTable("Price");
            
            modelBuilder.Entity<Order>().ToTable("Order");
            
            modelBuilder.Entity<User>().ToTable("User");            

            modelBuilder.Entity<UserOrder>().ToTable("UserOrder");
        }
    }
}
