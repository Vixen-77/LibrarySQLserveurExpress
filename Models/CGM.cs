using System.ComponentModel.DataAnnotations;

namespace LibrarySSMS.Models{
    public class CGM
    {
        [Key]
        public Guid IdCGM { get; set; }  // ajouter un service pour les prefix 
      
        public required string ADRMAC {get; set;}

        public required Guid idporteur {get; set;} 

        public float? Glycemia {get; set;}

        public required bool isGlyhigh {get; set;}

        public required bool isGlyLow {get; set;}

        public required float battry {get; set;}

}
}