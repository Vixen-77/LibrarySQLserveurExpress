using System.ComponentModel.DataAnnotations;

namespace LibrarySSMS.Models{
    public class Smartwatch {

        [Key]
        public required Guid IdSmartwatch {get; set;}
        public required string ADRMAC {get; set;}
        
        public required Guid idporteur { get; set; }
        
        public required string Marque { get; set; } 

        public required string Modele { get; set; } 

       //les meme atrribut que ce de lalgo de lannées passée 
       //age,  FC_capte,  PAS_capte, 
      //PAD_capte,  TGS_capte)  par  une  OBU
      //lattribut de lage sera transmit par requete 
        public int? FC_capte {get;set;}
        public int? PAS_capte {get;set;}
        public int? PAD_capte {get;set;}
        public float? TGS_capte {get;set;}



        public required bool IsConnected { get; set; }




//postion par rapport au norme de Open streetmap
              public double Latitude { get; set; }  // Précis et conforme à OSM
              public double Longitude { get; set; } // Précis et conforme à OSM
              public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC
    }
}