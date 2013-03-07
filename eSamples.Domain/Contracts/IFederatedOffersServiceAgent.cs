using System;

namespace eSamples.Domain.Contracts
{
    interface IFederatedOffersServiceAgent
    {
        System.Collections.Generic.List<ProductSample> GetProductAllocations(string hcpid);
    }
}
