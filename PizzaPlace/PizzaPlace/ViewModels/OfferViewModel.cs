using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.ViewModels
{
    public class OfferViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
