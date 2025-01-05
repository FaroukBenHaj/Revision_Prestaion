using SE.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE.Infrastructure.Configurations;
using SE.ApplicationCore.Domain;

namespace SE.Infrastructure
{
    public class AMContext: DbContext
    {

        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=PrestationDB;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PrestationConfiguration());           
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Pre-convention model configuration goes here
            configurationBuilder
                .Properties<string>()
                .HaveMaxLength(150);
        }
    }
}
