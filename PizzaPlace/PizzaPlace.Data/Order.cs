﻿using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Data
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required] 
        public string Message { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool IsProcessed { get; set; }
    }
}
