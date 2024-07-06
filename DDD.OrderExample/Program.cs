using DDD.OrderExample.Entities;
using DDD.OrderExample.Repositories;
using DDD.OrderExample.Services;

IOrderRepository orderRepository = new InMemoryOrderRepository();
OrderService orderService = new OrderService(orderRepository);

// Create a new order
var orderId = new OrderId(Guid.NewGuid());
orderService.CreateOrder(orderId);

// Add items to the order
orderService.AddItemToOrder(orderId, new OrderItem("Product1", 2));
orderService.AddItemToOrder(orderId, new OrderItem("Product2", 1));

// Retrieve and display the order
var order = orderService.GetOrder(orderId);
Console.WriteLine($"Order ID: {order.Id.Id}");
foreach (var item in order.Items)
{
    Console.WriteLine($"Product: {item.ProductName}, Quantity: {item.Quantity}");
}
