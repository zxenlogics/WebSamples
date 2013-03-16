using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;
using WebSample.Domain.Contracts;

namespace WebSample.Domain.Repositories
{
    public class FederatedOffersRepository : IFederatedOffersRepository
    {
        public List<Product> GetProductAllocations(string hcpid)
        {
            return new List<Product>()
            {
                new Product  { ProductID = "1", ProductDescription = "Rosingnol Snowboard", PrescribingInfoUrl = "http://www.microsoft.com" },
                new Product  { ProductID = "2", ProductDescription = "Hot Chilly Base Layer", PrescribingInfoUrl = "http://google.com" },
                new Product  { ProductID = "3", ProductDescription = "Smartwool 120mg Mid Layer", PrescribingInfoUrl = "http://www.citrix.com" },
                new Product  { ProductID = "4", ProductDescription = "Nalgene 16oz Water Bottle", PrescribingInfoUrl = "http://www.zeal.com" },
                new Product  { ProductID = "5", ProductDescription = "Zeal Optics Night Googles", PrescribingInfoUrl = "http://www.rei.com" }
            };
        }
    }
}
