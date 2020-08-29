using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Data
{
    public class Subscription
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
