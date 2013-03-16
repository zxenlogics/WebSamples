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
                new Product  { ProductID = "1", Name = "Rosingnol Snowboard", Description = "http://www.microsoft.com" },
                new Product  { ProductID = "2", Name = "Hot Chilly Base Layer", Description = "http://google.com" },
                new Product  { ProductID = "3", Name = "Smartwool 120mg Mid Layer", Description = "http://www.citrix.com" },
                new Product  { ProductID = "4", Name = "Nalgene 16oz Water Bottle", Description = "http://www.zeal.com" },
                new Product  { ProductID = "5", Name = "Zeal Optics Night Googles", Description = "http://www.rei.com" }
            };
        }
    }
}
