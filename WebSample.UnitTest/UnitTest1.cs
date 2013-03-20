using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WebSample.Model;
using WebSample.Domain;
using WebSample.Domain.Contracts;
using WebSample.Domain.Repositories;


namespace WebSample.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IFederatedOrdersRepository rep = new FederatedOrdersRepository();
            WebSampleDb db = new WebSampleDb();

            Address addr = new Address() 
                { 
                    //HcpId = "12346",
                    Address1 = "1545 Penn Plaza",
                    City = "New York",
                    State = "NY",
                    Zip = "10017"
                };
            db.Addresses.Add(addr);

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        [TestMethod]
        public void UserProfileTest()
        {
            IAccountRepository rep = new AccountRepository();
            List<UserProfile> user = rep.GetUsers();
            

        }

    }
}
