using PizzaPlace.Data;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Common.Helpers
{
    public static class ModelConverter
    {
        public static OfferViewModel ConvertToOfferViewModel(this Offer offer)
        {
            return new OfferViewModel
            {
                Title = offer.Title,
                Description = offer.Description,
                DateCreated = offer.DateCreated,
                Price = offer.Price
            };
        }
    }
}
