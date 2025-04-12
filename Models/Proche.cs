using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 namespace LibrarySSMS.Models{
     public class Proche{                                 

        [Key]
        public required Guid IdProche { get; set; } 

        public required Guid PatientUID { get; set; }

        [ForeignKey(nameof(PatientUID))]
        public virtual required Patient Patient { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

     }
 }