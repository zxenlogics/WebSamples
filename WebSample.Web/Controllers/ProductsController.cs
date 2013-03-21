using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSample.Models;
using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;

namespace WebSample.Web.Controllers
{
    public class ProductsController : Controller
    {
        IProductRepository db;

        public ProductsController()
        {
            db = new ProductRepository();
        }

        public ActionResult ViewAll()
        {
            IEnumerable<Product> products = db.GetProducts();
            
            return View("ErrorPage");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product model)
        {
            return View();
        }

    }
}
