using System.ComponentModel.DataAnnotations;


namespace LibrarySSMS.Models
{
    public class ArchivesUser
    {
        [Key]
        public required Guid IdArchives { get; set; } // UID de l'archive
        public required Guid user { get; set; } // UID du patient
        public required string Nom { get; set; }
        public required string Prenom { get; set; }
        public required string PhoneNumber { get; set; } // Optionnel
        public required string Email { get; set; }
        public required DateTimeOffset Timestamp { get; set; } // Format ISO 8601 + UTC
        public required string Role { get; set; } // Rôle de l'utilisateur (Patient, Proche, AdminH, etc.)
    }
}