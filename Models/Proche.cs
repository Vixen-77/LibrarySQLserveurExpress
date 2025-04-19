using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 namespace LibrarySSMS.Models{
     public class Proche{                                 

        [Key]
        public required string IdProche { get; set; }  // melinda 


        public required Guid PatientUID { get; set; } 
        [ForeignKey(nameof(PatientUID))]
        public virtual Patient? Patient { get; set; }

        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

     }
 }