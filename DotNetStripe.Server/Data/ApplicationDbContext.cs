using DotNetStripe.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetStripe.Server.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        const int amountOfProductsToSeed = 20;

        var productsToSeed = new Product[amountOfProductsToSeed];
        var Guid = "25a8358b-36b3-48e2-8301-127ac0806e3";
        for (var i = 0; i < amountOfProductsToSeed; i++)
        {
            productsToSeed[i] = new Product
            {
                Id = $"{Guid}{i}",
                Title = $"Product {i}",
                Description = $"Description of product {i}, This is an amazing product with a price-quality balance you won't find anywhere else.",
                ImageUrl = $"https://picsum.photos/id/{i}/500",
                Price = 1000 + i
            };
        }

        modelBuilder.Entity<Product>().HasData(productsToSeed);
    }
}
