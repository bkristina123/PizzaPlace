using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Common.Helpers;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace
{
    public class MenuModel : PageModel
    {
        private readonly IOfferService _offerService;

        public List<MenuItemViewModel> MenuItems { get; set; }

        public MenuModel(IOfferService offerService)
        {
            this._offerService = offerService;
        }

        public void OnGet()
        {
           MenuItems = _offerService.GetAllMenuItems().
                Select(x => x.ConvertToMenuItemViewModel())
                .ToList();
        }
    }
}