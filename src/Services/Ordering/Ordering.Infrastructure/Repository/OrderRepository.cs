using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Ordering.Application.Contacts.Persistence;
using Ordering.Domain.Models;
using Ordering.Infrastructure.Persistence;

namespace Ordering.Infrastructure.Repository
{
    public class OrderRepository : CommonRepository<Order>, IOrderRepository
    {
        OrderDBContext _dbContext;
        public OrderRepository(OrderDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserName(string userName)
        {
            var orderList = await _dbContext.Orders.Where(o => o.UserName.ToLower() == userName.ToLower()).ToListAsync();
            return orderList;
        }
    }
}
