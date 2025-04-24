namespace LibrarySSMS.Enums
{
    public enum MedRecState
    {
        unvalid =-1,        
        Pending =0,
        valid =1,       // Correction : "passagé" -> "Passager" (orthographe)
        
         
    }
} // en effet il faut rajouter un nombre car test entity ne supporte pas les enum a string et les convertie direct en numero dou le changement