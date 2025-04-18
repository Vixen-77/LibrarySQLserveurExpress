

using System.Runtime.CompilerServices;

namespace LibrarySSMS.Models{
public class NotificationSuperAdmin
{
    public int Id { get; set; } // id de la notification volatile meme en db int est suffisant 
    public Guid AdminUID { get; set; } // <- utilisé en WHERE
    public Guid SuperAdminUID { get; set; } // <- utilisé en WHERE
    public required string Message { get; set; }
    public string? report { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsRead { get; set; }
}
}
