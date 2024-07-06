using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.OrderExample.Entities
{
    // Value Object
    public class OrderId
    {
        public Guid Id { get; }

        public OrderId(Guid id)
        {
            Id = id;
        }

        // Override Equals and GetHashCode for value equality
        public override bool Equals(object obj)
        {
            if (obj is OrderId other)
            {
                return Id.Equals(other.Id);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Value Object
    public class OrderItem
    {
        public string ProductName { get; }
        public int Quantity { get; }

        public OrderItem(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }
    }

    // Entity
    public class Order
    {
        public OrderId Id { get; }
        public List<OrderItem> Items { get; }

        public Order(OrderId id)
        {
            Id = id;
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }



}
