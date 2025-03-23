using System.ComponentModel.DataAnnotations;

namespace LibrarySSMS.Models{
    public class SmartwatchNewGen {

        [Key]
        public required Guid IdSmartwatchNewGen {get; set;}
        public required string ADRMAC {get; set;}
        
        public required Guid idporteur { get; set; }
        
        public required string Marque { get; set; } 

        public required string Modele { get; set; } 

       //les 14 attribut venu du dataset pour compatibilité avec LSTM  
        public required bool IsConnected { get; set; }
        public bool Anomalie { get; set; }



//postion par rapport au norme de Open streetmap
            public float? lat {get; set;}
            public float? lon {get; set;}
            public DateTime Timestamp { get; set; } // Format ISO 8601
    }
}