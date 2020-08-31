using PizzaPlace.Data;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void AddOrder(Order order)
        {
            orderRepository.AddOrder(order);
        }

        public void AddSubscription(string email)
        {
            var subscription = new Subscription
            {
                Email = email
            };
            orderRepository.AddSubscription(subscription);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }

        public Order GetOrderById(int id)
        {
            return orderRepository.GetOrderById(id);
        }

        public void UpdateOrder(int id)
        {
            Order order = orderRepository.GetOrderById(id);

            order.IsProcessed = true;
            orderRepository.UpdateOrder(order);
        }
    }
}
