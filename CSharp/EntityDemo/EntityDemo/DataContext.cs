using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo
{
    internal class DataContext : DbContext
    {
        public DataContext() 
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=EntityDB;Integrated Security=true");
        }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(x => x.CustomerCode);
            modelBuilder.Entity<Customer>().Property(x => x.Name).HasColumnName("CustomerName");
            modelBuilder.Entity<Customer>().ToTable("CustomerDetails");

            modelBuilder.Entity<Customer>().Property(x => x.City).IsRequired(false);
            modelBuilder.Entity<Customer>().HasCheckConstraint("CheckAge", "Age>=18");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
