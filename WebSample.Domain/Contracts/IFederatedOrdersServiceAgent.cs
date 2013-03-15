using System;

using WebSample.Model;

namespace WebSample.Domain.Contracts
{
    interface IFederatedOrdersServiceAgent
    {
        Address GetAddressInfo(string hcpID);
        OrderDetails GetLastOrderDetails(string hcpId);
        SrfDocument GetSrfPreview(Srf srf);
        bool SubmitSrf(Srf srf);
    }
}
