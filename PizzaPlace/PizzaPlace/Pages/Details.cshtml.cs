using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Common.Helpers;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    public class DetailsModel : PageModel
    {
        private readonly IOfferService _offerService;

        public MenuItemViewModel MenuItem { get; set; }

        public DetailsModel(IOfferService offerService)
        {
            this._offerService = offerService;
        }

        public void OnGet(int id)
        {
            MenuItem = _offerService.GetMenuItemById(id)
                .ConvertToMenuItemViewModel();
        }
    }
}