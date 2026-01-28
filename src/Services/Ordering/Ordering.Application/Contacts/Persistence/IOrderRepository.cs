using EF.Core.Repository.Interface.Repository;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;

namespace Ordering.Application.Contacts.Persistence
{
    public interface IOrderRepository : ICommonRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
