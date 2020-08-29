using PizzaPlace.Data;
using PizzaPlace.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly PizzaPlaceDbContext _context;

        public OfferRepository(PizzaPlaceDbContext context)
        {
            this._context = context;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _context.MenuItems.Add(menuItem);
            _context.SaveChanges();
        }

        public void AddOffer(Offer offer)
        {
            _context.Offers.Add(offer);
            _context.SaveChanges();
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _context.MenuItems.ToList();
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            return _context.Offers.ToList();
        }

        public MenuItem GetMenuItemById(int id)
        {
            return _context.MenuItems.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
