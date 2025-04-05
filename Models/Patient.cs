using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibrarySSMS.Models;
using LibrarySSMS.Enums;
using System.Text.Json.Serialization;
using Azure.Identity;

namespace LibrarySSMS.Models
{
    public class Patient 


    {
        [Key]
        public required Guid UID { get; set; } 

        public  string? MedicalRecordPath { get; set; } //lien du fichier du patient au moment de l'inscription

        [EmailAddress]
        public required string MailMed { get; set;} 

        // clé etrangère 
        [ForeignKey(nameof(Proche))]
        public required Guid IdProche { get; set; } // la clé etrangère Id
        public virtual required Proche Proche { get; set; } // navigation property  
        // la configuration de la bonne navigation 


        public required UserState State { get; set; } // l'état du patient

        [EmailAddress]
        public required string Email { get; set; }   

        public required string PasswordHash { get; set; } 
        public required string Salt { get; set; }

        public required string Name { get; set; }
        public required string LastName { get; set; }



        public required int Age {get; set;}
        public required bool Gender {get; set;}   //0 si femme et 1 si homme
        public required double Weight {get; set;} 
        public required double Height {get;set;}
        public required BloodType bloodType {get; set;}
        public required string Adresse { get; set; }
        public required string PostalCode { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string PhoneNumber { get; set; } // Optionnel
        public DateTime CreatedAt { get; set; } 
        public DateTime? LastLogin { get; set; }
        public required bool AccountStatus  {get; set; }   // false=normale true= user suspendu
        public bool TwoFactorEnabled { get; set; } 
        public bool?  SubscriptionPlan { get; set; }  //false=gratuit true=payant  //avoir si on peut le faire
        public bool IsOnline { get; set; } 
        public required RoleManager Role { get; set; }


        
        public Guid?  IdphoneP { get; set; } 
        public Guid?  IdSmartwatchNewGenP {get; set;}
        public required Guid? IdSmartwatchP {get; set;}
        public Guid? IdVehiculeOBUP {get;set;}
        public Guid? IdCGMP { get; set; }


        public required bool IsActive { get; set; }
        public bool IsValidated { get; set; }  // Par défaut : false et se mettra a true plus tard 
        public int? NbSec { get; set;} 
    }
}
