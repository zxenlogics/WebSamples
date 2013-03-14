using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSamples.Domain
{
    public interface IBusinessLogic
    {
        IList<ProductSample> GetSampleOffers();
        Address GetPreviousAddress(string hcpId);
    }
}
