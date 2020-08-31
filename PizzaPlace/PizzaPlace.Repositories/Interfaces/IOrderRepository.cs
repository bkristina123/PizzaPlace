using PizzaPlace.Data;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void AddSubscription(Subscription subscription);
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void UpdateOrder(Order order);
    }
}
