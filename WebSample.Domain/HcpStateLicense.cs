using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Domain
{
    public class HcpStateLicense
    {
        public enum Status { Active, Inactive }

        [Key]
        public int StateLicenseId { get; set; }
        public string HcpId { get; set; }
        public string ExpirationDate { get; set; }
        public string LicensenseEffectiveDate { get; set; }
        public string LicenseNumber { get; set; }
        public string StateCode { get; set; }
        public string StateLicenseStatusDescription { get; set; }
        public Status LicenseStatus { get; set; }
        public string ValidationDate { get; set; }
    }
}
