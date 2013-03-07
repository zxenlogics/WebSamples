using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eSamples.Domain;
using eSamples.Domain.Contracts;

namespace eSamples.Domain.Repositories
{
    public class FederatedOrdersRepository : IFederatedOrdersRepository
    {
        


        public Address GetAddressInfo(string hcpID)
        {
            eSamplesDb db = new eSamplesDb();
            //Address a = db.Addresses.Find(hcpID);
            //return a;
            return db.Addresses.Single(a => a.HcpId == hcpID);
        }

        public void CreateAddress(Address address)
        {
            eSamplesDb db = new eSamplesDb();
            db.Addresses.Add(address);
        }

        public OrderDetails GetLastOrderDetails(string hcpId)
        {
            throw new NotImplementedException();
        }

        public SrfDocument GetSrfPreview(Srf srf)
        {
            throw new NotImplementedException();
        }

        public bool SubmitSrf(Srf srf)
        {
            throw new NotImplementedException();
        }
    }
}
