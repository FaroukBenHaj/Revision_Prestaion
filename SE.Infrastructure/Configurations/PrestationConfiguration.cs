using SE.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Infrastructure.Configurations
{
    public class PrestationConfiguration : IEntityTypeConfiguration<Prestation>
    {
        public void Configure(EntityTypeBuilder<Prestation> builder)
        {
            builder.HasKey(r => new { r.HeureDebut, r.PrestataireFK, r.ClientFK });
            builder.HasOne(r=>r.Prestataire).WithMany(s=>s.Prestations).HasForeignKey(r => r.PrestataireFK);
            builder.HasOne(r => r.Client).WithMany(c => c.Prestations).HasForeignKey(r => r.ClientFK);

        }
    }
}
