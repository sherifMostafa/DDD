using DDD.OrderExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OrderExample.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly Dictionary<Guid, Order> _orders = new Dictionary<Guid, Order>();

        public void Add(Order order)
        {
            _orders[order.Id.Id] = order;
        }

        public Order GetById(OrderId id)
        {
            _orders.TryGetValue(id.Id, out var order);
            return order;
        }
    }

}
