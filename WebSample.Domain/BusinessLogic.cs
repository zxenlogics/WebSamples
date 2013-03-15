using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;

namespace WebSample.Domain
{
    public class BusinessLogic : IBusinessLogic
    {
        public IList<ProductSample> GetSampleOffers()
        {
            return new List<ProductSample> 
            { 
                new ProductSample { ProductDescription = "Viagra", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "20" },
                new ProductSample { ProductDescription = "Chantix", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "10" },
                new ProductSample { ProductDescription = "Prevnar", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "30" },
                new ProductSample { ProductDescription = "Lyrica", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "20" },
                new ProductSample { ProductDescription = "Zanthax", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "20" },
                new ProductSample { ProductDescription = "Phenzic", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "10" },
                new ProductSample { ProductDescription = "Dipitol", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "200" },
                new ProductSample { ProductDescription = "Celebrex", PrescribingInfoDescription = "Prescribing Information", AllocatedQuantity = "50" }
            };
        }

        public Address GetPreviousAddress(string hcpId)
        {
            return new Address()
            {
                Address1 = "One Pfizer Place",
                City = "New York",
                State = "NY",
                Zip = "10017",
                Phone = "(212) 733-3559",               
            };
        }

    }
}
