using System;
using System.Collections.Generic;

using WebSample.Model;

namespace WebSample.Domain.Contracts
{
    interface IFederatedOffersServiceAgent
    {
        List<ProductSample> GetProductAllocations(string hcpid);
    }
}
