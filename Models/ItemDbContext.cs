using Microsoft.EntityFrameworkCore;

namespace Product.Models
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext (DbContextOptions<ProductDbContext> options)
        : base(options)
        {
        }

        public DbSet<Items> Items {get; set;} = default!;
    }

    public class Items
    {
    }
}