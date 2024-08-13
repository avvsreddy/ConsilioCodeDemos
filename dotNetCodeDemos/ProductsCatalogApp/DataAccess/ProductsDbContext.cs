using Microsoft.EntityFrameworkCore;
using ProductsCatalogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalogApp.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        // map to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyProductsDb2024;Integrated Security=True;MultipleActiveResultSets=True").UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //[Key]
            // Fluent API
            //modelBuilder.Entity<Product>().HasKey(e => e.ItemId);
        }


        // map to tables

        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }


    }
}
