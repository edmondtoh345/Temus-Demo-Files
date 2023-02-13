using Microsoft.EntityFrameworkCore;

namespace LayeredAppDemo.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
