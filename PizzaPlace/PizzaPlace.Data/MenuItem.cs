using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Data
{
    public class MenuItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
