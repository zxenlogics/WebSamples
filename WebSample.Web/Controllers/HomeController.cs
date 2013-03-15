using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSample.Model;
using WebSample.Domain;
using WebSample.Web.Models;

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
            var repository = new BusinessLogic();
            IList<ProductSample> samples = repository.GetSampleOffers();
            return View(samples);
        }

        [HttpGet]
        public ActionResult Shipping()
        {
            var repository = new BusinessLogic();
            var addr = repository.GetPreviousAddress("25642");
            var shipModel = new ShippingModel();
            shipModel.Address1 = addr.Address1;
            shipModel.City = addr.City;
            shipModel.State = addr.State;
            shipModel.Zip = addr.Zip;
            shipModel.Phone = addr.Phone;
            shipModel.Sln = "NY5421";

            return View(shipModel);
        }

    }
}
