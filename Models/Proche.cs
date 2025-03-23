using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 namespace LibrarySSMS.Models{
     public class Proche{                                 

        [Key]
        public required Guid IdProche { get; set; } 
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

     }
 }