using System.ComponentModel.DataAnnotations;
using LibrarySSMS.Models;
using LibrarySSMS.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySSMS.Models
{
    public class ProS 
    {
      public required Availibility IsAvailable { get; set; }
      public required bool AcceptRequest { get; set; } // true si le proS accepte l'urgence 
      public DateTime? DateAcceptRequest { get; set; } // date d'acceptation de la demande d'urgence
      public required bool CheckedSchedule { get; set; } // true si le proS a a consulté toute les alerte 


      [Key]
        public required Guid UID { get; set; } 
    
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
        public DateTime? LastLogin { get; set;}
         public required bool AccountStatus  {get; set;}   // false=normale true= user suspendu
        public required bool IsBanned { get; set; }

        public bool TwoFactorEnabled { get; set; } 
        public required bool  SubscriptionPlan { get; set;}  //false=gratuit true=payant  //avoir si on peut le faire
        public bool IsOnline { get; set;} 
        public required RoleManager Role { get; set; }

        public required bool IsActive { get; set; }
        public Guid? IdVehiculeOBUSVP {get;set;}
        public Guid? IdSmartphoneProS {get;set;}
        public float? latitudePro { get; set; }
        public float? longitudePro { get; set; }


       //FIXME: ici les fichier idf et certif
      public required string identite { get; set; }
       public required string Certif {get;set;} 
      
      public required bool ConfMail { get; set; } 
     public int IsValidated { get; set; }  // defaut->0:pas / traite 1:valide / -1:rejeté

      public string? ProfilPic {get;set;}

      public bool IsDeleted { get; set; } // Pour le soft delete
      public DateTime? DeletedAt { get; set; } // Pour le soft delete

       //voir si on rajouter des attribut ou ideé intéréssante
    }
}
