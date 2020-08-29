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
            var subscription = new Subscription();
            subscription.Email = email;
            orderRepository.AddSubscription(subscription);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }
    }
}
