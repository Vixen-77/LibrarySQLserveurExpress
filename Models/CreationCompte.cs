namespace LibrarySSMS.Models
{
public class CreationCompte
{
    public required Guid Id { get; set; } // id de la notification volatile meme en db int est suffisant 
    public required Guid UserUID { get; set; }
    public required string Role { get; set; } // 10: patient 20: proS
    public required int State { get; set; }//0:pas encore traité 1:traité
    public required Guid AdminUID { get; set; } // <- utilisé en WHERE
    public DateTime CreatedAt { get; set; }
    public bool? IsRead { get; set; }
}

}