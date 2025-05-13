namespace LibrarySSMS.Models
{
public class CreationCompte
{
    public int Id { get; set; } // id de la notification volatile meme en db int est suffisant 
    public Guid? userUID { get; set; }
    public required int State {get; set;}//0:pas encore traité 1:traité
    public Guid? AdminUID { get; set; } // <- utilisé en WHERE
    public required string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool? IsRead { get; set; }
}

}