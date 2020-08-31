using PizzaPlace.Data;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OrderRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void AddSubscription(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            context.SaveChanges();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void UpdateOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }
    }
}
