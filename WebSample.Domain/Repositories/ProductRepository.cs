using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;
using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;

namespace WebSample.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        WebSampleDb db;

        public ProductRepository()
        {
            db = new WebSampleDb();
        }

        public IEnumerable<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public Product GetProductByName(string name)
        {
            return db.Products.First(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            return db.Products.Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void Add(Product product)
        {
            db.Products.Add(product);
        }

        public void CreateProduct(Product product)
        {
            Product p = GetProductByName(product.Name);
            if (p != null)
            {
                throw new ArgumentException("A product alredy exists with the name: " + product.Name);
            }

            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            Product p = db.Products.Find(productId);
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
