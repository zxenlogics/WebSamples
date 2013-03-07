using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eSamples.Domain.Contracts;

namespace eSamples.Domain
{
    public class FederatedOrdersServiceAgent : ServiceAgentBase, IFederatedOrdersServiceAgent
    {

        public OrderDetails GetLastOrderDetails(string hcpId)
        {
            return new OrderDetails();
        }

        public Address GetAddressInfo(string hcpID)
        {
            return new Address();
        }

        public bool SubmitSrf(Srf srf)
        {
            return true;
        }

        public SrfDocument GetSrfPreview(Srf srf)
        {
            return new SrfDocument();
        }
    }
}
