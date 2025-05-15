
namespace LibrarySSMS.Models{
public class HelpForm
{
    public required Guid ID { get; set; } 
    public required Guid UID { get; set; } 
    public required string Role { get; set; }
    public required string Email { get; set; }
    public required string Body { get; set; } 
    public required DateTime CreatedAt { get; set; }
}
}