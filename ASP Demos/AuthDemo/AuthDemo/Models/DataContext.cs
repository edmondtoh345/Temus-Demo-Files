using Microsoft.EntityFrameworkCore;

namespace AuthDemo.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get;set; }

    }
}
