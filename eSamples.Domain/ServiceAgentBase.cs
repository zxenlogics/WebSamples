using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace eSamples.Domain
{
    public abstract class ServiceAgentBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void OnServiceFailure()
        {

        }


        protected void OnServiceSuccessful()
        {

        }

    }
}
