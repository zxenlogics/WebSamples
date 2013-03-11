using System;
using System.Collections.Generic;

namespace eSamples.Domain.Contracts
{
    public interface IFederatedOffersRepository
    {
        List<ProductSample> GetProductAllocations(string hcpid);
    }
}
