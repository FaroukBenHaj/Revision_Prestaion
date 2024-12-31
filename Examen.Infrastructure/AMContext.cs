using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{

    /*
     * Sans Utiliser les classes de configurations 
     * |-> Dans ce cas on utillise la classe contexte 
     */
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=MohamedFaroukBenHajAmorPrestataire;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Appele à  la classe de configuration au cas ou on a un eclasse

            modelBuilder.ApplyConfiguration(new PrestationConfiguration());
            //modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
            //modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>()
            //    .HaveColumnType("date");

            //configurationBuilder.Properties<String>().HaveMaxLength(50);
        }
    //Les requetes 
        public DbSet<Client> Clients { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Prestation>  Prestations { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
      //public DbSet<Staff> Staff { get; set; }

        /*
         *Afin d'acceder la console du gestionnaire du Package on clique sur : 
         *|-> Tools 
         *  |->Nuget Package Manager 
         *         |-> Package Manager Console 
         *          |-> Pointé sur examen.Infrastructure 
         *                  |-> PM>add-migration M1
         *                      
         *                      
         */
    }
}
