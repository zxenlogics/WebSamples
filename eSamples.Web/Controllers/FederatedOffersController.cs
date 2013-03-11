﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using eSamples.Domain.Contracts;
using eSamples.Domain.Repositories;
using eSamples.Domain;

namespace eSamples.Web.Controllers
{
    public class FederatedOffersController : Controller
    {
        //
        // GET: /FederatedOffers/

        public ActionResult Samples()
        {
            IFederatedOffersRepository repository = new FederatedOffersRepository();
            IEnumerable<ProductSample> samples = repository.GetProductAllocations("234");
            return View(samples);
        }

    }
}
