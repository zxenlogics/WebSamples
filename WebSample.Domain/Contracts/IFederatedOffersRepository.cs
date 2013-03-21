using System;
using System.Collections.Generic;

using WebSample.Models;

namespace WebSample.Domain.Contracts
{
    public interface IFederatedOffersRepository
    {
        List<Product> GetProductAllocations(string hcpid);
    }
}
