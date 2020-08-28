using System;

namespace PizzaPlace.Data
{
    public class Offer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
