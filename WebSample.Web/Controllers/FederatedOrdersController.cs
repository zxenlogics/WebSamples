using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSample.Domain;
using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;

namespace WebSample.Web.Controllers
{
    [Authorize]
    public class FederatedOrdersController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

         [HttpGet]
        public ActionResult Address(string id)
        {
            IFederatedOrdersRepository rep = new FederatedOrdersRepository();
            Address addr = rep.GetAddressInfo(id);
            return View(addr);
        }

        [HttpPost]
        public ActionResult Address(Address address)
        {
            return View();
        }

        //
        // GET: /FederatedOrders/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FederatedOrders/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /FederatedOrders/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /FederatedOrders/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /FederatedOrders/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /FederatedOrders/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
