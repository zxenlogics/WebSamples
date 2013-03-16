using System;
using System.Collections.Generic;

using WebSample.Model;

namespace WebSample.Domain.Contracts
{
    public interface IFederatedOffersRepository
    {
        List<Product> GetProductAllocations(string hcpid);
    }
}
