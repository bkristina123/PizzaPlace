using PizzaPlace.Data;
using System.Collections.Generic;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOfferService
    {
        IEnumerable<Offer> GetAll();
    }
}
