using Microsoft.EntityFrameworkCore;
using LibrarySSMS.Models;

namespace LibrarySSMS
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Ajoute ici tes DbSet pour chaque table gérée par cette bibliothèque
        
      public DbSet<Patient> Patientss { get; set; }
      public DbSet<ProS> ProSs { get; set; }
      public DbSet<RespHop> RespHops{ get; set; }
      public DbSet<Admin> Admins {get;set;}
      public DbSet<SuperAdmin> SuperAdmins {get; set;}
      public DbSet<Proche> Proches { get; set; }
      public DbSet<MedRec> MedRecs { get; set; }
      public DbSet<Centre> Centress { get; set; }
      public DbSet<SVEmbulance> SVEmbulances { get; set; }
      public DbSet<SmartwatchNewGen> SmartwatchNewGens { get; set; }
      public DbSet<Smartwatch> Smartwatches { get; set; }
      public DbSet<Smartphone> Smartphones { get; set; }
      public DbSet<VehiculeOBU> VehiculeOBUs { get; set; }
      public DbSet<CGM> CGMs {get; set;}
    }
}