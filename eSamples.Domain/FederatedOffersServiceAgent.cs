using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eSamples.Domain.Contracts;

namespace eSamples.Domain
{
    public class FederatedOffersServiceAgent : ServiceAgentBase, IFederatedOffersServiceAgent
    {

        public List<ProductSample> GetProductAllocations(string hcpid)
        {
            return new List<ProductSample>();
        }


    }

}
