using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSample.Models;

namespace WebSample.Domain
{
    public class WebSampleDb : DbContext
    {
        public WebSampleDb() : base("name=DefaultConnection") { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        //public DbSet<HcpStateLicense> HcpLicenses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
