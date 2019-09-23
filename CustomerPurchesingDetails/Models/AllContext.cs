using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPurchesingDetails.Models
{
    public class AllContext : DbContext
    {
        public AllContext(DbContextOptions<AllContext> options) :
            base(options)
        {
            Database.Migrate();
        }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Items> items { get; set; }
        public DbSet<Invoice> invoices { get; set; }
    }
}