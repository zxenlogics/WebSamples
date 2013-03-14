using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Domain.Contracts;

namespace WebSample.Domain.Repositories
{
    public class FederatedOffersRepository : IFederatedOffersRepository
    {
        public List<ProductSample> GetProductAllocations(string hcpid)
        {
            return new List<ProductSample>()
            {
                new ProductSample  { ProductID = "1", ProductDescription = "Rosingnol Snowboard", PrescribingInfoUrl = "http://www.microsoft.com" },
                new ProductSample  { ProductID = "2", ProductDescription = "Hot Chilly Base Layer", PrescribingInfoUrl = "http://google.com" },
                new ProductSample  { ProductID = "3", ProductDescription = "Smartwool 120mg Mid Layer", PrescribingInfoUrl = "http://www.citrix.com" },
                new ProductSample  { ProductID = "4", ProductDescription = "Nalgene 16oz Water Bottle", PrescribingInfoUrl = "http://www.zeal.com" },
                new ProductSample  { ProductID = "5", ProductDescription = "Zeal Optics Night Googles", PrescribingInfoUrl = "http://www.rei.com" }
            };
        }
    }
}
