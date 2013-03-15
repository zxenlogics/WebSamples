using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Model;

namespace WebSample.Domain
{
    public class HcpLookupServiceAgent : ServiceAgentBase
    {
        public static List<HcpStateLicense> GetHcpStateLicenses(string hcpId)
        {
            return new List<HcpStateLicense>();
        }
    }
}
