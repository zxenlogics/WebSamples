using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSample.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        // Air, Rail, Road, Water, Cable, Pipeline, Space
        public string TransportMode { get; set; }
        public VehicleType Type { get; set; }
    }

    public class VehicleType
    {
        //Aircraft, Bus, Vessel(ship), Train
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
    }
}
