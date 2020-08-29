using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.ViewModels
{
    public class MenuItemViewModel
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
