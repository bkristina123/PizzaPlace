using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Data;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace
{
    public class ViewOrdersModel : PageModel
    {
        private readonly IOrderService orderService;

        public IEnumerable<Order> Orders { get; set; }

        public ViewOrdersModel(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public void OnGet()
        {
            Orders = orderService.GetAllOrders();
        }
    }
}