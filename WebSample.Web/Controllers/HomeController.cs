using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;
using WebSample.Model;

namespace WebSample.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult RequestSamples()
        {
            IFederatedOffersRepository repository = new FederatedOffersRepository();
            IList<Product> samples = repository.GetProductAllocations("1254");
            return View(samples);
        }

        [HttpGet]
        public ActionResult Shipping()
        {
            IFederatedOrdersRepository repository = new FederatedOrdersRepository();
            var addr = repository.GetAddressInfo("25642");
            var shipModel = new Address();

            shipModel.Address1 = addr.Address1;
            shipModel.City = addr.City;
            shipModel.State = addr.State;
            shipModel.Zip = addr.Zip;

            return View(shipModel);
        }

    }
}
