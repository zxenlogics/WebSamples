using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSample.Models
{
    public class TransportManifestDetails
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ManifestDetailsId { get; set; }
        public int ManifestId { get; set; }
        public string SSN { get; set; }
    }
}
