using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibrarySSMS.Models;
using LibrarySSMS.Enums;
using System.Text.Json.Serialization;
using Azure.Identity;
using System.Diagnostics.CodeAnalysis;

namespace LibrarySSMS.Models
{
    public class SuperAdmin
    {
        [Key]
        public required Guid UIDKEY { get; set; } 
        public required Guid UID {get; set;}
    
        [EmailAddress]
        public required string Email { get; set; }
        
        public required string PasswordHash { get; set; }
        
        public required string Salt { get; set; }

        public required string FullName { get; set; }
        public required string PhoneNumber { get; set; } // Optionnel
        public DateTime? LastLogin { get; set; }
        public bool? TwoFactorEnabled { get; set; } 
        public bool IsOnline { get; set; } 
        public required RoleManager Role { get; set; }

        public required bool IsActive { get; set; }

        public int? nbSuspendedAdminacount {get; set;}
        public int? nbDeletedAdminacount {get; set;}
    }
}
