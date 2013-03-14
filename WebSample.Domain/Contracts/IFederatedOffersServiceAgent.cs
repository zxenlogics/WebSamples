using System;
using System.Collections.Generic;

namespace WebSample.Domain.Contracts
{
    interface IFederatedOffersServiceAgent
    {
        List<ProductSample> GetProductAllocations(string hcpid);
    }
}
