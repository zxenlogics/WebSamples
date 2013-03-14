using System;
using System.Collections.Generic;

namespace eSamples.Domain.Contracts
{
    interface IFederatedOffersServiceAgent
    {
        List<ProductSample> GetProductAllocations(string hcpid);
    }
}
