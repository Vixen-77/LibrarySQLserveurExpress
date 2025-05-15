using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySSMS.Models
{
    public class SVEmbulance
    {
        [Key]
        public required Guid IdEmbulance { get; set; } // UID de l'embulance 
        public required string Matricule { get; set; } // Matricule de l'embulance
        
        public bool? IsConnected { get; set; }
        public required string PasswordHash { get; set; } // Mot de passe de l'embulance
        

          public Guid? IdAdminH { get; set; } 
          [ForeignKey(nameof(IdAdminH))]
          public virtual AdminH? AdminH { get; set; }

          public Guid? IdCentre { get; set; } 
          [ForeignKey(nameof(IdCentre))]
          public virtual Centre? Centre { get; set; }

        public required bool isAmbulanceReady { get; set; } // true si l'ambulance est prête à partir
        public bool isAmbulanceAvailable { get; set; } // true si l'ambulance est disponible pour une mission
        public bool isAmbulancePanne { get; set; } // true si l'ambulance est en panne
        
        
        public double Latitude { get; set; }  // Précis et conforme à OSM
        public double Longitude { get; set; } // Précis et conforme à OSM
        public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC

    }
}
