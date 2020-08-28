using PizzaPlace.Data;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaPlace.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            this._offerRepository = offerRepository;
        }

        public IEnumerable<Offer> GetAll()
        {
           return _offerRepository.GetAll();
        }
    }
}
