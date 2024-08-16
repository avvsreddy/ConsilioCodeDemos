using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyContactsApp.Models;

namespace MyContactsApp.Data
{
    public class MyContactsAppContext : DbContext
    {
        public MyContactsAppContext (DbContextOptions<MyContactsAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyContactsApp.Models.Contact> Contact { get; set; } = default!;
    }
}
