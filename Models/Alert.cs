
namespace LibrarySSMS.Models{
public class Alert
{
    public int Id { get; set; } // id de la notification volatile meme en db int est suffisant 
    public Guid PatientUID { get; set; } // <- utilisé en WHERE
    public Guid? ProSID {get; set;}
    public required string Color {get; set;}
    public int State {get; set;} //0: pas encore traite  1:en cours de traitement  2: finis 
    public string? Descrip { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool? IsRead { get; set; }
    public string? Location {get; set;}
}
}