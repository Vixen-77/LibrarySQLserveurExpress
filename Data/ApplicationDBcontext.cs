using Microsoft.EntityFrameworkCore;
using LibrarySSMS.Models;

namespace LibrarySSMS
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Ajoute ici tes DbSet pour chaque table gérée par cette bibliothèque
        
      public DbSet<Patient> Patientss { get; set; } //1
      public DbSet<ProS> ProSs { get; set; } //2
      public DbSet<AdminH> AdminHs{ get; set; } //3
      public DbSet<Admin> Admins {get;set;} //4
      public DbSet<SuperAdmin> SuperAdmins {get; set;} //5
      public DbSet<Proche> Proches { get; set; } //6
      public DbSet<MedRec> MedRecs { get; set; } //7
      public DbSet<Centre> Centress { get; set; } //8
      public DbSet<SVEmbulance> SVEmbulances { get; set; } //9
      public DbSet<SmartwatchNewGen> SmartwatchNewGens { get; set; } //10
      public DbSet<Smartwatch> Smartwatches { get; set; } //11
      public DbSet<Smartphone> Smartphones { get; set; }  //12
      public DbSet<VehiculeOBU> VehiculeOBUs { get; set; }  //13
      public DbSet<CGM> CGMs {get; set;} //14
      public DbSet<NotificationAdmin> Notificationadmins { get; set; } // Ajout de la DbSet pour les notifications 15
      public DbSet<NotificationAdminAlert> NotificationAdminAlerts { get; set; } // Ajout de la DbSet pour les notifications admin 16
      public DbSet<NotificationServiceClient> NotificationServiceClients { get; set; } // Ajout de la DbSet pour les notifications service client 17
      public DbSet<NotificationSuperAdmin> NotificationSuperAdmins { get; set; } // Ajout de la DbSet pour les notifications 18
      public DbSet<NotifAlertPatient> NotifAlertPatients { get; set; } // Ajout de la DbSet pour les notifications alert patient 19
      public DbSet<NotifAlertVoisin> NotifAlertVoisins { get; set; } // Ajout de la DbSet pour les notifications alert voisin 20

    }
}