using Microsoft.EntityFrameworkCore;

namespace Product.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext (DbContextOptions<ProductDbContext> options)
        : base(options)
        {
        }

        public DbSet<Products> Products {get; set;} = default!;
    }
}
