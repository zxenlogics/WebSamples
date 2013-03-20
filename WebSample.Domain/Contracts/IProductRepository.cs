using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;

namespace WebSample.Domain.Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        IEnumerable<Product> GetProductsByName(string name);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
