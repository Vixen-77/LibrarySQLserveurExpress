using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySSMS.Models
{
    public class Centre
    {
        [Key]
        public required Guid IdC { get; set; } // UID du centre


        [ForeignKey(nameof(RespHop))]
        public required Guid UID { get; set; }  // la clé etrangère Id
        public virtual required RespHop RespHop { get; set; } // navigation property 
        
        
        public required string NomC { get; set; }
        public required string Adresse { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public int Nbamb { get; set; }

        public double Latitude { get; set; }  // Précis et conforme à OSM
        public double Longitude { get; set; } // Précis et conforme à OSM
        public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC
    }
}
