using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using eSamples.Domain;
using eSamples.Domain.Contracts;
using eSamples.Domain.Repositories;

namespace eSamples.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFederatedOrdersRepository rep = new FederatedOrdersRepository();
            eSamplesDb db = new eSamplesDb();

            Address addr = new Address() 
                { 
                    HcpId = "12346",
                    Address1 = "1545 Penn Plaza",
                    City = "New York",
                    State = "NY",
                    Zip = "10017"
                };
            db.Addresses.Add(addr);
            db.SaveChanges();
        }




    }
}
