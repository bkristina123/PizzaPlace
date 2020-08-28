using Microsoft.EntityFrameworkCore;

namespace PizzaPlace.Data
{
    public class PizzaPlaceDbContext : DbContext
    {
        public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) : base(options)
        {

        }

        public DbSet<Offer> Offers { get; set; }
    }
}
