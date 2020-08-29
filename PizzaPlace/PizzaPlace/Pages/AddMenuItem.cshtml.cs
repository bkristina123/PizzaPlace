using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Common.Helpers;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    public class AddMenuItemModel : PageModel
    {
        private readonly IOfferService _offerService;

        [BindProperty]
        public MenuItemViewModel MenuItem { get; set; }

        public AddMenuItemModel(IOfferService offerService)
        {
            this._offerService = offerService;
        }

        public IActionResult OnGet()
        {
            MenuItem = new MenuItemViewModel();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _offerService.AddMenuItem(MenuItem.ConvertToMenuItemEntity());
                return RedirectToPage("Success");
            }

            return Page();
        }
    }
}