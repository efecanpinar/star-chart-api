using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // Orbited = Yörüngeli
        public int? OrbitedObjectId { get; set; }
        // Satellites = uydular
        // Celestial = göksel
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }
        // Yörünge dönemi
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
