using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Domain
{
    public class OrderDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HcpDEANumber { get; set; }
        public string HcpDesignation { get; set; }
        public string HcpEmail { get; set; }
        public string HcpID { get; set; }
        public string HcpStateLicenseNumber { get; set; }
        public string IsESignature { get; set; }
        public string SRFNumber { get; set; }
        public SortedDictionary<string, string> ProductList { get; set; }
        public Address Address { get; set; }
    }
}
