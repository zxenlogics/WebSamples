using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eSamples.Domain.Contracts;

namespace eSamples.Domain.Repositories
{
    public class FederatedOffersRepository : IFederatedOffersRepository
    {
        public List<ProductSample> GetProductAllocations(string hcpid)
        {
            return new List<ProductSample>()
            {
                new ProductSample  { ProductID = "1", ProductDescription = "Rosingnol Snowboard" }
                new ProductSample  { ProductID = "2", ProductDescription = "Hot Chilly Base Layer" },
                new ProductSample  { ProductID = "3", ProductDescription = "Smartwool 120mg Mid Layer" },
                new ProductSample  { ProductID = "4", ProductDescription = "Nalgene 16oz Water Bottle" },
                new ProductSample  { ProductID = "5", ProductDescription = "Zeal Optics Night Googles" }
            };
        }
    }
}
