using System.ComponentModel.DataAnnotations;


namespace LibrarySSMS.Models{
 public class Smartphone {

        [Key]
        public Guid Idphone { get; set; }  // ajouter un service pour les prefix 
      
        public required string ADRMAC {get; set;}

        public required string Marque { get; set; } 

        public required string Modele { get; set; } 

        public required Guid idporteur {get; set;} 

        public required float battry {get; set;} 

        public required bool IsConnected {get; set;}
   


        public double Latitude { get; set; }  // Précis et conforme à OSM
        public double Longitude { get; set; } // Précis et conforme à OSM
        public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC

 }
}