using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySSMS.Models
{
    public class SVEmbulance
    {
        [Key]
        public required Guid IdEmbulance { get; set; } // UID de l'embulance 
        

          public Guid? IdRespHop { get; set; } 
          [ForeignKey(nameof(IdRespHop))]
          public virtual RespHop? RespHop { get; set; }

          public Guid? IdCentre { get; set; } 
          [ForeignKey(nameof(IdCentre))]
          public virtual Centre? Centre { get; set; }

        public required bool isAmbulanceReady { get; set; } // true si l'ambulance est prête à partir
        
        public double Latitude { get; set; }  // Précis et conforme à OSM
        public double Longitude { get; set; } // Précis et conforme à OSM
        public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC

    }
}
