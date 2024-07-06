using DDD.OrderExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OrderExample.Repositories
{
    // Repository Interface
    public interface IOrderRepository
    {
        void Add(Order order);
        Order GetById(OrderId id);
    }
}
