using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Domain
{
    public class HcpUserInfo
    {
        public string HcpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfessionalDesignationCode { get; set; }
        public string ProfessionalDesignationDesc { get; set; }
    }
}
