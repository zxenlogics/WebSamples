using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;

namespace WebSample.Domain
{
    public interface IBusinessLogic
    {
        IList<ProductSample> GetSampleOffers();
        Address GetPreviousAddress(string hcpId);
    }
}
