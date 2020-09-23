using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Common.Helpers;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    [Authorize]
    public class AddOfferModel : PageModel
    {
        private readonly IOfferService _offerService;

        [BindProperty]
        public OfferViewModel Offer { get; set; }

        public AddOfferModel(IOfferService offerService) 
        {
            this._offerService = offerService;
            Offer = new OfferViewModel();

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _offerService.AddOffer(Offer.ConvertToOfferEntity());
                return RedirectToPage("Success");
            }

            return Page();
        }
    }
}