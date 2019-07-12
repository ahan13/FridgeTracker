using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeTracker
{
    class FridgeContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ItemsDb;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Item>().HasKey(a => a.ItemNumber);
            modelBuilder.Entity<Item>(e =>
            {
                e.Property(a => a.ItemNumber).ValueGeneratedOnAdd();
                e.Property(a => a.Name).IsRequired().HasMaxLength(100);
                e.Property(a => a.DateAdded).IsRequired();
                e.Property(a => a.Quantity).IsRequired();
// e.Property(a => a.Type).IsRequired();
            });
        }
    }
}
