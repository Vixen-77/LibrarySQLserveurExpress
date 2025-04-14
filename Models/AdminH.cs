
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using LibrarySSMS.Enums;
namespace LibrarySSMS.Models{
public class AdminH 
{
    
      
        
        [Key]
        public required Guid UID { get; set; } 
        public required string UIDKEY { get; set; } // UID de l'admin H

        public virtual ICollection<SVEmbulance>? SVEmbulances { get; set; }
       
        
        [EmailAddress]
        public required string Email { get; set; }
        
        public required string PasswordHash { get; set; }
        
        public required string Salt { get; set; }

        public required string FullName { get; set; }
        public required string Adress { get; set; }
        public required string PostalCode { get; set; }
        public required string PhoneNumber { get; set; } // Optionnel
        public DateTime CreatedAt { get; set; }
        public required  DateTime DateofBirth {get;set;}
        public required int Age {get; set;}
        public required bool Gender {get; set;}
        public DateTime? LastLogin { get; set; }
        public required bool AccountStatus  {get; set; }   // false=normale true= user suspendu
        public bool IsOnline { get; set; } 
        public required RoleManager Role { get; set; }


        


        public bool IsSuspended { get; set; } // 🔴 Admin suspendu ou pas
        public bool? DBmanipulation {get; set;} // 0 si pas de manipulation 1 si manipulation de la base de donnée

        public required bool IsActive { get; set; }
}
}


