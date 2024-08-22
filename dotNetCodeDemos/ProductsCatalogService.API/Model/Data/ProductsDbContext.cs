using Microsoft.EntityFrameworkCore;
using ProductsCatalogService.API.Model.Entities;

namespace ProductsCatalogService.API.Model.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options):base(options)
        {
            // config db
        }

        // config tables
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Smartphone X1",
                    Description = "Latest model with high-resolution camera and fast processor",
                    Price = 799,
                    Category = "Electronics",
                    IsAvailable = true,
                    Brand = "TechBrand",
                    Country = "USA"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Laptop Pro 15",
                    Description = "Powerful laptop with 16GB RAM and 512GB SSD",
                    Price = 1299,
                    Category = "Computers",
                    IsAvailable = true,
                    Brand = "ComputeTech",
                    Country = "Germany"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Wireless Headphones",
                    Description = "Noise-cancelling over-ear headphones with long battery life",
                    Price = 199,
                    Category = "Accessories",
                    IsAvailable = false,
                    Brand = "SoundGear",
                    Country = "Japan"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Smart TV 55\"",
                    Description = "Ultra HD 4K Smart TV with built-in streaming apps",
                    Price = 499,
                    Category = "Electronics",
                    IsAvailable = true,
                    Brand = "ViewMax",
                    Country = "South Korea"
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Running Shoes",
                    Description = "Comfortable and durable running shoes with excellent grip",
                    Price = 120,
                    Category = "Sportswear",
                    IsAvailable = true,
                    Brand = "SportX",
                    Country = "India"
                }
            );
        }
    }
}
