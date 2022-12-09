using Microsoft.EntityFrameworkCore;

namespace Product.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext (DbContextOptions<ProductDbContext> options)
        : base(options)
        {
        }

        public DbSet<Customers> Customers {get; set;} = default!;
    }

    public class Customers
    {
    }
}