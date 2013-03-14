using System;
using System.Collections.Generic;

namespace WebSample.Domain.Contracts
{
    public interface IFederatedOffersRepository
    {
        List<ProductSample> GetProductAllocations(string hcpid);
    }
}
