using DDD.OrderExample.Entities;
using DDD.OrderExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OrderExample.Services
{
    public class OrderService(IOrderRepository _orderRepository)
    {
        public void CreateOrder(OrderId orderId)
        {
            var order = new Order(orderId);
            _orderRepository.Add(order);
        }

        public void AddItemToOrder(OrderId orderId, OrderItem item)
        {
            var order = _orderRepository.GetById(orderId);
            if (order != null)
            {
                order.AddItem(item);
            }
        }

        public Order GetOrder(OrderId orderId)
        {
            return _orderRepository.GetById(orderId);
        }
    }

}
