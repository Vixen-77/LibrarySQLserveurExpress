
                         //  FIXME:FIXME:FIXME:FIXME:NOTE IMPORTANTE SUR AppDbContextFactory:FIXME:FIXME:FIXME:FIXME:FIXME:

/*FIXME: ce code est consu pour la creation des migration et linstantion de appDBcontext iniciale 
 il est selement utiliser lors des migration des table et va jamais etre utiliser 
plus tard car la chaine de connexion est désormais gere par les deux API (principale et secondaire)
TODO: cependant ne supprimez pas ce bout de code on le décommantera dans le cas ou on veut faire dautre migrations*/



/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LibrarySSMS
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Chaîne de connexion (remplace avec la tienne)
            var connectionString = "fczookjiGITfPPHkfzjfzjefziiikdaelaazdlafb;ealkfnDhyged"; //this connextion is hashed try harder next time :) 
            
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}*/
 