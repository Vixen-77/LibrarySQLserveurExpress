
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using LibrarySSMS.Enums;
namespace LibrarySSMS.Models{
public class RespHop 
{
    
      
        
        [Key]
        public required Guid UID { get; set; } 

        public virtual ICollection<SVEmbulance>? SVEmbulances { get; set; }
       
        
        [EmailAddress]
        public required string Email { get; set; }
        
        public required string PasswordHash { get; set; }
        
        public required string Salt { get; set; }

        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Adress { get; set; }
        public required string PostalCode { get; set; }
        public required string PhoneNumber { get; set; } // Optionnel
        public DateTime CreatedAt { get; set; }
        public required  DateTime DateofBirth {get;set;}
        public required int Age {get; set;}
        public required bool Gender {get; set;}
        public DateTime? LastLogin { get; set; }
        public required bool AccountStatus  {get; set; }   // false=normale true= user suspendu
        public bool TwoFactorEnabled { get; set; } 
        public required bool  SubscriptionPlan { get; set; }  //false=gratuit true=payant  //avoir si on peut le faire
        public bool IsOnline { get; set; } 
        public required RoleManager Role { get; set; }


        //FIXME: ici les fichier idf et certif 
        public required string identite {get;set;}
        public required string Certif {get;set;}



        public required bool IsActive { get; set; }
        public required bool IsValided { get; set; } // true si le compte est validé par l'admin
        public Guid? IdVehiculeOBUSV {get;set;}
}
}


