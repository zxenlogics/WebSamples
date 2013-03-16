using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;
using WebSample.Domain.Contracts;

namespace WebSample.Domain.Repositories
{
    public class FederatedOrdersRepository : IFederatedOrdersRepository
    {
        


        public Address GetAddressInfo(string hcpID)
        {
            //eSamplesDb db = new eSamplesDb();
            ////Address a = db.Addresses.Find(hcpID);
            ////return a;
            //return db.Addresses.Single(a => a.HcpId == hcpID);

            return new Address 
            {
                Address1 = "235 42nd Street",
                City = "New York",
                State = "NY",
                Zip = "10017",
            };
        }

        public void CreateAddress(Address address)
        {
            //eSamplesDb db = new eSamplesDb();
            //db.Addresses.Add(address);
        }

        public OrderDetails GetLastOrderDetails(string hcpId)
        {
            throw new NotImplementedException();
        }

    }
}
