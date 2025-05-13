

using System.Runtime.CompilerServices;

namespace LibrarySSMS.Models{
public class NotificationAdminAlert
{
    public int Id { get; set; } // id de la notification volatile meme en db int est suffisant 
    public Guid patientUID { get; set; } // <- utilisé en WHERE
    public Guid ProSID {get; set;}
    public required string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
}
}