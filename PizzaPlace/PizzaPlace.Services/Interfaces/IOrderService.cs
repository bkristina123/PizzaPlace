using PizzaPlace.Data;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        void AddSubscription(string email);
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void UpdateOrder(int id);
    }
}
