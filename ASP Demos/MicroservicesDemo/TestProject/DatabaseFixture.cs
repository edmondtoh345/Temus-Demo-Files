using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class DatabaseFixture : IDisposable
    {
        public DataContext db;
        public DatabaseFixture()
        {
            var options = new DbContextOptionsBuilder<DataContext>().EnableSensitiveDataLogging(true).UseInMemoryDatabase("ProductsDB").Options;
            db = new DataContext(options);
            db.ChangeTracker.Clear();
        }
        public void Dispose()
        {
            db = null;
        }
    }
}
