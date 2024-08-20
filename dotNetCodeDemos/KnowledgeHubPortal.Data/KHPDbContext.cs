using KnowledgeHubPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Data
{
    public class KHPDbContext : DbContext
    {
        // map db
        public KHPDbContext()
        {
            
        }
        public KHPDbContext(DbContextOptions<KHPDbContext> options):base(options)
        {
            // configuring through mvc / web api
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=KHPDb2024;Integrated Security=True;Encrypt=True");
            }
        }
        // map tables

        public DbSet<Category>  Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
