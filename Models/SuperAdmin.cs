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
        public required Guid UID {get; set;}
        public required string UIDKEY { get; set; } 
    
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

        public int? DBmanipulation {get; set;} // 0 si il a le droit de manipuler la base de données et 1 sinon

        public virtual ICollection<AdminH>? AdminHs { get; set; }
        public virtual ICollection<SVEmbulance>? Embulances { get; set; }
        public virtual ICollection<Centre>? Centres { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; } // Liste des patients gérés par l'admin
        public virtual ICollection<Proche>? Proches { get; set; } // Liste des proches gérés par l'admin
        public virtual ICollection<MedRec>? MedRecs { get; set; } // Liste des dossiers médicaux gérés par l'admin
        public virtual ICollection<Smartwatch>? SmartWatches { get; set; } // Liste des montres gérées par l'admin
        public virtual ICollection<SmartwatchNewGen>? SmartWatchesNewGen { get; set; } // Liste des montres gérées par l'admin
        public virtual ICollection<Smartphone>? Phones { get; set; } // Liste des téléphones gérés par l'admin
        public virtual ICollection<ProS>? Prosss { get; set; } // Liste des médicaments gérés par l'admin
        public virtual ICollection<CGM>? CGMs { get; set; } // Liste des CGM gérés par l'admin
        public virtual ICollection<Admin>? Admins { get; set; } // Liste des admins gérés par le super admin
        public virtual ICollection<VehiculeOBU>? VehiculeOBUss { get; set; } // Liste des super admins gérés par le super admin
    }
}
