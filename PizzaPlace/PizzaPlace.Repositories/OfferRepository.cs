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

        public IEnumerable<Offer> GetAll()
        {
            return _context.Offers.ToList();
        }
    }
}
