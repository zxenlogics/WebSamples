using System;
using System.Collections.Generic;

using WebSample.Model;

namespace WebSample.Domain.Contracts
{
    public interface IFederatedOffersRepository
    {
        List<ProductSample> GetProductAllocations(string hcpid);
    }
}
