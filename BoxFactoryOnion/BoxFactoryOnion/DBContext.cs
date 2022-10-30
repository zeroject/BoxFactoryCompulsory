using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DBContext(DbContextOptions<DBContext> options, ServiceLifetime service) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Box>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
            model.Entity<Customer>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
            model.Entity<Order>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
            model.Entity<Box>()
                .HasOne<Order>()
                .WithMany(f => f.boxes)
                .HasForeignKey(f => f.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Box> Boxs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
