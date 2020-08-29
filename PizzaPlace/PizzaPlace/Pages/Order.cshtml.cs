using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Data;
using PizzaPlace.Services.Interfaces;

namespace PizzaPlace
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService orderService;

        [BindProperty]
        public Order Order { get; set; }

        public OrderModel(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public IActionResult OnGet()
        {
            Order = new Order();
            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                orderService.AddOrder(Order);
                return RedirectToPage("Success");
            }

            return Page();
        }

        public IActionResult OnGetSubscribe()
        {
            return Page();
        }

        public IActionResult OnPostSubscribe(string email)
        {
           orderService.AddSubscription(email);
           return RedirectToPage("Success");
        }
    }
}