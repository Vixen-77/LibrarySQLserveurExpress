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
   


        public required float lat {get; set;}
        public required float lon {get; set;}
        public DateTime Timestamp { get; set; } // Format ISO 8601

 }
}