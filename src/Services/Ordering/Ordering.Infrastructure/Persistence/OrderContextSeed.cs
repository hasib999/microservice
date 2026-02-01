using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    UserName = "hasibsanto0@gmail.com",
                    FirstName = "Hasib",
                    LastName = "Shanto",
                    EmailAddress = "hasibsanto0@gmail.com",
                    Address = "Dhaka, Bangladesh",
                    TotalPrice = 100m,
                    City = "Dhaka",
                    CVV = "Test",
                    State = "Dhaka",
                    ZipCode = "1206",
                    CardName = "Test",
                    CardNumber = "Test",
                    PhoneNumber = "01700000000",
                    CreatedBy = "system",
                    CreatedDate = new DateTime(2026, 2, 1, 0, 0, 0, DateTimeKind.Utc),
                    PaymentMethod = "Test",
                    Expiration = "Test"
                });
        }
    }
}
