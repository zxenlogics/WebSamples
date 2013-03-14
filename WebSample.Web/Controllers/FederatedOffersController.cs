using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;
using WebSample.Domain;

namespace WebSample.Web.Controllers
{
    [Authorize]
    public class FederatedOffersController : Controller
    {
        [Authorize]
        public ActionResult Samples()
        {
            IFederatedOffersRepository repository = new FederatedOffersRepository();
            IEnumerable<ProductSample> samples = repository.GetProductAllocations("234");
            return View(samples);
        }

    }
}
