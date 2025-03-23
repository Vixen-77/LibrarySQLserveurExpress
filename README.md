**Instruction dutilisation**
ceci est un projet ASP.NET Librery est l'intermédiaire entre les deux API (PFE principale et secondaire)

le docier Data conteant:
**Data**
ApplicationDbconext.cs
et AppDbContexFacotry.cs
AppDbContext permet de définir les table a migrer
et AppDbContexFacotry permet a ef core (entity framework ORM) d'instencier dbcontext afin de génere les les migrations

**Enumes et Models**
contenant la strcuture des tables et attribut + Enumération associer 
pour des réson technique les enumération on une notation d'entier car ef core ne supporte pas les type complexe
et les transforme en type prémitif dans la base de donnée 

*Migrations*
docier conteaner des fichier générer automatiquement par ef core l'ors de la commande :
*dotnet ef migrations add nom_de_migration_devotrechoix*
 (A NE PAS MODIFIER) conteient lhistorique des modification 




