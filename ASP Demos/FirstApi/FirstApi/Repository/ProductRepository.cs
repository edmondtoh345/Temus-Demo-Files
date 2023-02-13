using FirstApi.Models;
using Microsoft.EntityFrameworkCore;
namespace FirstApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext db;
        public ProductRepository(DataContext db) 
        {
            this.db = db;
        }
        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges();
        }

        public int DeleteProduct(int id)
        {
            var p = db.Products.Where(x => x.Id== id).FirstOrDefault();
            if(p != null)
            {
                db.Products.Remove(p);
                return db.SaveChanges();
            }
            return 0;
        }

        public Product GetProduct(int id)
        {
            return db.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public int UpdateProduct(int id, Product product)
        {
            var p = db.Products.Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                p.Name = product.Name;
                p.Brand = product.Brand;
                p.Quantity= product.Quantity;
                p.Price= product.Price;
                db.Entry<Product>(p).State = EntityState.Modified;
                return db.SaveChanges();
            }
            return 0;
        }
    }
}
