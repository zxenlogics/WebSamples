using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eSamples.Domain
{
    public class eSamplesDb : DbContext
    {
        public eSamplesDb() : base("name=DefaultConnection") { }
        
        public DbSet<HcpStateLicense> HcpLicenses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProductSample> ProductSamples { get; set; }
    }
}
