using Microsoft.EntityFrameworkCore;

namespace Product.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var coontext = new ProductDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProductDbContext>>()))
            {
                //Look for any products
                if (context.Product.Any())
                {
                    return;//DB seeded
                }
                ContextBoundObject.Products.AddRange(
                    new Products
                    {
                        Name = "Beans"
                    },
                    new Products
                    {
                        Name = "Tortillas"
                    },
                    new Products
                    {
                        Name = "Amanti Guacamole Cheese"
                    },
                    new Products
                    {
                        Name = "Honey Mustard"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}