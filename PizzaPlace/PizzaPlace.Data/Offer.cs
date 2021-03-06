﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Data
{
    public class Offer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
