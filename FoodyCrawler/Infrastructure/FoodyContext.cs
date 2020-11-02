using FoodyCrawler.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodyCrawler.Infrastructure
{
    public class FoodyContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=foody.db");
    }
}
