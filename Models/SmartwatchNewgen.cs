using System.ComponentModel.DataAnnotations;

namespace LibrarySSMS.Models{
    public class SmartwatchNewGen {

        [Key]
        public required Guid IdSmartwatchNewGen {get; set;}
        public required string ADRMAC {get; set;}
        
        public required Guid idporteur { get; set; }
        
        public required string Marque { get; set; } 

        public required string Modele { get; set; } 

       //les 14 attribu venu du dataset pour compatibilité avec LSTM  (Cpateur de la montre)

 /*1*/     public int? Heart_Rate {get;set;}
 /*2*/     public int? Respiratory_Rate {get;set;}
 /*3*/     public double? Body_Temperature {get;set;}
 /*4*/     public double? Oxygen_Saturation {get; set;}
 /*5*/     public int? Systolic_Blood_Pressure {get; set;}
 /*6*/     public int? Diastolic_Blood_Pressure {get; set;}
 
 /*7*/     //lage est mit dans la table patient et rtrouver via request.age avec une ingtérogation de la DB dans le hub
           //lattribut de lage sera transmit par requete 

 /*8*/    //le genr aussi sera mit transmi avec une requete
 /*9*/     
 /*10*/    //le poids et la taille aussi seront transmit par requete
 /*11*/    public double? Derived_HRV  {get; set;}
 /*12*/    public int? Derived_Pulse_Pressure {get; set;}
 /*13*/    public double? Derived_BMI  {get; set;}
 /*14*/    public double? Derived_MAP {get; set;}

          public required bool IsConnected { get; set; }

//postion par rapport au norme de Open streetmap
          public double Latitude { get; set; }  // Précis et conforme à OSM
          public double Longitude { get; set; } // Précis et conforme à OSM
          public DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC
          public required string IpAdress {get; set;}
    }
}