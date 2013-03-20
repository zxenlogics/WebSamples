using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WebSample.Model;
using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;

namespace WebSample.UnitTest
{
    [TestClass]
    public class ProductTest
    {
        IProductRepository _context;

        [TestInitialize]
        public void Init()
        {
            _context = new ProductRepository();
        }

        [TestMethod]
        public void CreateProduct_Pass()
        {
            Product p = new Product
            {
                Name = "Motorola Android", Description = "Real walking, talking Android from outter space"
            };
            Product p1 = new Product
            {
                Name = "Rosingnol Snowboard", Description = "Back country snowboard"
            };
            _context.CreateProduct(p);
            _context.CreateProduct(p1);
        }

        [TestMethod]
        public void CreateProduct_Fail()
        {
            Product p = new Product
            {
                Description = "This should not be in the database"
            };
            _context.CreateProduct(p);
          
        }

        [TestMethod]
        public void GetProductByName_Pass()
        {
            Product p = _context.GetProductByName("Motorola Android");
            Console.WriteLine("Found product: " + p.Name);
        }

        [TestMethod]
        public void GetProductById_Pass()
        {
            Product p = _context.GetProductById(1);
            Assert.IsNotNull(p);
        }
    }
}
