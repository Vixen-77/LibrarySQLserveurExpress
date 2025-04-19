using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibrarySSMS.Models;
using LibrarySSMS.Enums;
using System.Text.Json.Serialization;
using Azure.Identity;
using System.Diagnostics.CodeAnalysis;

namespace LibrarySSMS.Models
{
    public class MedRec 
{   
    [Key]
    public required Guid UIDMedRec { get; set; }

    public required string FilePath { get; set; }  // Lien du fichier du patient

    public required MedRecState State { get; set; } // Etat du fichier (valide, non valide, en attente)
    public DateTime CreatedAt { get; set; }

    [EmailAddress]
    public required string MailMed { get; set; }



    // Clé étrangère vers Patient
    public required Guid PatientUID { get; set; }

    [ForeignKey(nameof(PatientUID))]
    public virtual Patient? Patient { get; set; }
}

}