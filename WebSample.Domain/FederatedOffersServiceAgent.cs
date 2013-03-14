using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Domain.Contracts;

namespace WebSample.Domain
{
    public class FederatedOffersServiceAgent : ServiceAgentBase, IFederatedOffersServiceAgent
    {

        public List<ProductSample> GetProductAllocations(string hcpid)
        {
            return new List<ProductSample>();
        }


    }

}
