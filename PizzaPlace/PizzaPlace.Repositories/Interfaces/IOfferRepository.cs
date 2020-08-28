using PizzaPlace.Data;
using System.Collections.Generic;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> GetAll();
    }
}
