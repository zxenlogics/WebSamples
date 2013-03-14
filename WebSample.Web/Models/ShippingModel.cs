using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSamples.Web.Models
{
    public class ShippingModel
    {
        public string OrganizationName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Sln { get; set; }
    }
}