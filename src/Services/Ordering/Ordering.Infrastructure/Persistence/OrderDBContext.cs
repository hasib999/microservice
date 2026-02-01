using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderDBContext : DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
        { 
            
        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
           .Property(o => o.TotalPrice)
           .HasPrecision(18, 2);
            await OrderContextSeed.Seed(modelBuilder);
        }
        public DbSet<Order> Orders { get; set; }
    }
}
