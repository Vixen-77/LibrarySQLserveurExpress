
using System.ComponentModel.DataAnnotations;

namespace LibrarySSMS.Models{
    public class Alert
    {
        [Key]
        public Guid PatientUID { get; set; } // <- utilisé en WHERE
        public Guid? ProSID { get; set; }
        public required string Color { get; set; } //orange rouge
        public int State { get; set; } //0: pas encore traite  1:en cours de traitement  2: finis 
        public string? Descrip { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? IsRead { get; set; }
        public string? Location { get; set; } //nom de la rue
        public required string latitudePatient { get; set; }
        public required string longitudePatient { get; set; }
}
}