using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;


namespace Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Item> items { get; set; }

    }
}