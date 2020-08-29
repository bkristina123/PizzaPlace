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
                Id = offer.Id,
                Title = offer.Title,
                Description = offer.Description,
                DateCreated = offer.DateCreated,
                Price = offer.Price,
            };
        }


        public static Offer ConvertToOfferEntity(this OfferViewModel offer)
        {
            return new Offer
            {
                Id = offer.Id,
                Title = offer.Title,
                Description = offer.Description,
                DateCreated = offer.DateCreated,
                Price = offer.Price
            };
        }

        public static MenuItem ConvertToMenuItemEntity(this MenuItemViewModel menuItem)
        {
            return new MenuItem
            {
                Id = menuItem.Id,
                Title = menuItem.Title,
                ImageUrl = menuItem.ImageUrl,
                Price = menuItem.Price,
            };
        }

        public static MenuItemViewModel ConvertToMenuItemViewModel(this MenuItem menuItem)
        {
            return new MenuItemViewModel
            {
                Id = menuItem.Id,
                Title = menuItem.Title,
                ImageUrl = menuItem.ImageUrl,
                Price = menuItem.Price,
            };
        }
    }
}
