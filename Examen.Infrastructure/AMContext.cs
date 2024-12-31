using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{

    /**
     * Sans Utiliser les classes de configurations 
     * |-> Dans ce cas on utillise la classe contexte 
     */
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=ExamenDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new FlightConfiguration());
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


        //public DbSet<Flight> Flights { get; set; }
        //public DbSet<Passenger> Passengers { get; set; }
        //public DbSet<Plane> Planes { get; set; }
        //public DbSet<Traveller> Travellers { get; set; }
        //public DbSet<Staff> Staff { get; set; }

    }
}
