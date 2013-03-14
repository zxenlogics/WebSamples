using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSample.Extensions;

namespace WebSample.Domain
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public string HcpId { get; set; }
        public string OrganizationName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        //public bool IsValid()
        //{
        //    Func<Address, bool>[] rules =
        //        {
        //            //a => !a.OrganizationName.IsNullOrWhiteSpace(),
        //            //a => a.OrganizationName.Length <= 50,
        //            a => !string.IsNullOrWhiteSpace(a.Address1),
        //            a => a.Address1.Length <= 50,
        //            a => ! string.IsNullOrWhiteSpace(a.City),
        //            a => !string.IsNullOrWhiteSpace(a.State),
        //            a => a.State.Length == 2,
        //            a => !string.IsNullOrWhiteSpace(a.Zip),
        //            a => a.Zip.RemoveHyphensAndWhiteSpaces().Length == 5 || a.Zip.RemoveHyphensAndWhiteSpaces().Length == 9
        //        };

        //    return rules.All(rule => rule(this) == true);
        //}
    }
}
