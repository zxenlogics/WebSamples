using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Model
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [Required]        
        [StringLength(5)]
        public string HcpId { get; set; }
        [Required]
        [MinLength(4), MaxLength(50)]
        public string Address1 { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        [MinLength(4), MaxLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [StringLength(5)]
        public string Zip { get; set; }        
    }
}
