using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySSMS.Models
{
    public class Centre
    {
        [Key]
        public required Guid IdC { get; set; } // UID du centre


        public required Guid AdminHUID { get; set; }
        [ForeignKey(nameof(AdminHUID))]
        public virtual required AdminH AdminH { get; set; }
        public virtual required ICollection<SVEmbulance> SVEmbulances { get; set; } = new List<SVEmbulance>();      
        
        public required string NomC { get; set; }
        public required string AdresseCentre { get; set; }
        public required string PhoneNumber { get; set; } // Optionnel
        public int Nbamb { get; set; }

        public double Latitude { get; set; }  // Précis et conforme à OSM
        public double Longitude { get; set; } // Précis et conforme à OSM

        public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC
    }
}
