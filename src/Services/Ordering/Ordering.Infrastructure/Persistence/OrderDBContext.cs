using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderDBContext : DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
        { 
            
        }
        public DbSet<Order> Orders { get; set; }
    }
}
