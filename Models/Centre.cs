using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySSMS.Models
{
    public class Centre
    {
        [Key]
        public required Guid IdC { get; set; } // UID du centre


        public required Guid RespHoptUID { get; set; }
        [ForeignKey(nameof(RespHoptUID))]
        public virtual required RespHop RespHop { get; set; }
        public virtual required ICollection<SVEmbulance> SVEmbulances { get; set; } = new List<SVEmbulance>();
        
        
        public required string NomC { get; set; }
        public required string AdresseCentre { get; set; }
        public int Nbamb { get; set; }

        public double Latitude { get; set; }  // Précis et conforme à OSM
        public double Longitude { get; set; } // Précis et conforme à OSM

        public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC
    }
}
