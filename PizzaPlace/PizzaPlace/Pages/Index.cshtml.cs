using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Common.Helpers;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOfferService _offerService;

        public List<OfferViewModel> Offers { get; set; }

        public IndexModel(IOfferService offerService)
        {
            Offers = new List<OfferViewModel>();
            this._offerService = offerService;
        }

        public void OnGet()
        {
            Offers = _offerService.GetAll()
                .Select(x => x.ConvertToOfferViewModel())
                .ToList();
        }
    }
}
