using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PizzaPlace.Data
{
    public class PizzaPlaceDbContext : IdentityDbContext
    {
        public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) : base(options)
        {

        }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
