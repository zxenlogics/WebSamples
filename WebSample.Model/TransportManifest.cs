using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSample.Model
{
    class TransportManifest
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ManifestId { get; set; }

        [ForeignKey("VehicleId")]
        public int VehicleId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}
