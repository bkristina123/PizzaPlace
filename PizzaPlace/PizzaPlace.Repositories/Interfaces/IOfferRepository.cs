using PizzaPlace.Data;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> GetAllOffers();
        void AddOffer(Offer offer);
        IEnumerable<MenuItem> GetAllMenuItems();
        void AddMenuItem(MenuItem menuItem);
        MenuItem GetMenuItemById(int id);
    }
}
