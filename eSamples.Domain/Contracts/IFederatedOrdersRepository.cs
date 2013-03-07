using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSamples.Domain.Contracts
{
    public interface IFederatedOrdersRepository
    {
        Address GetAddressInfo(string hcpID);
        OrderDetails GetLastOrderDetails(string hcpId);
        SrfDocument GetSrfPreview(Srf srf);
        bool SubmitSrf(Srf srf);
    }
}
