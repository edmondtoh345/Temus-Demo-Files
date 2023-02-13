using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using ProductAPI.Repository;
using System;

namespace TestProject
{
    public class Tests
    {
        private readonly IProductRepository repo;
        DatabaseFixture fixture;
        public Tests()
        {
            fixture = new DatabaseFixture();
            repo = new ProductRepository(fixture.db);
            repo.AddProduct(new Product { Id = 101, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 598 });
            repo.AddProduct(new Product { Id = 102, Name = "Tablet", Brand = "Samsung", Quantity = 3, Price = 259 });
        }
        [SetUp]
        public void SeedData()
        {

        }

        [Test, Order(1)]
        public void GetProductsTest()
        {
            var products = repo.GetProducts();
            Assert.Greater(products.Count, 0);
        }

        [Test, Order(2)]
        public void GetProductByIdTest()
        {
            var product = repo.GetProduct(101);
            Assert.AreEqual("Laptop", product.Name);
        }

        [Test, Order(2)]
        public void AddProductShouldSuccess()
        {
            int res = repo.AddProduct(new Product { Id=103, Name = "Camera", Brand = "Canon", Quantity = 4, Price = 678 });
            Assert.AreEqual(1, res);
        }

        [Test, Order(3)]
        public void GetProductsShouldReturnList()
        {
            var res = repo.GetProducts();
            Assert.IsAssignableFrom<List<Product>>(res);    
        }


    }
}