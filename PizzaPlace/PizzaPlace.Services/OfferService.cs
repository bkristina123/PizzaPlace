using PizzaPlace.Data;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
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

        public void AddMenuItem(MenuItem menuItem)
        {
            _offerRepository.AddMenuItem(menuItem);
        }

        public void AddOffer(Offer offer)
        {
            offer.DateCreated = DateTime.Now;
            _offerRepository.AddOffer(offer);
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _offerRepository.GetAllMenuItems();
        }

        public IEnumerable<Offer> GetAllOffers()
        {
           return _offerRepository.GetAllOffers();
        }

        public MenuItem GetMenuItemById(int id)
        {
            return _offerRepository.GetMenuItemById(id);
        }
    }
}
