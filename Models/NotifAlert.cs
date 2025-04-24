using System.Runtime.CompilerServices;

namespace LibrarySSMS.Models{
public class NotifAlertPatient
{
    public int Id { get; set; } // id de la notification volatile meme en db int est suffisant 
    public Guid UID { get; set; } // id du patient
    public required string Titre { get; set; }
    public string? Description { get; set; } // description de la notification
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
}
}
