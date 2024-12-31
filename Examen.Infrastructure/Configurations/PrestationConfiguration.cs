using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    /*
     * Question 3:
     * Une classe de configuration doit implimenter une interface IEntityTypeConfiguration<Prestation>
     */
    public class PrestationConfiguration : IEntityTypeConfiguration<Prestation>
    {
        public void Configure(EntityTypeBuilder<Prestation> builder)
        {
            /* Question 3.a
             * a relation entre Client, Prestataire et Prestation afin que les clés étrangère de cette relation
             * soient mappées vers des colonnes nommées ClientFK etPrestataireFK. 
             * 
             * On ajoute ClientFK et  PrestataireFK pour la configurere dans cette classe
             */
            builder.HasOne(p => p.MyClient)
                .WithMany(c => c.Prestations)
                .HasForeignKey(p => p.ClientFK);

            builder.HasOne(p => p.MyPrestataire)
                .WithMany(f => f.Prestations)
                .HasForeignKey(p => p.PrestataireFK);

            /* Question 3.b
             * La clé primaire de la classe Prestation afin qu’elle soit composée 
             * par les trois propriétés ClientFK, PrestataireFK et HeureDebut.
             */
            builder.HasKey(p => new
            {
                p.ClientFK,
                p.PrestataireFK,
                p.HeureDebut,
            });

            /*
             * Dans le cas ou il nous demande de la configurer en utilisant 
             * les annotation des données 
             * |
             * |-> [ PrimaryKey ("ClientFk" , "PrestataireFk" , "HeureDebut") ]
             * 
             **/

            /*  Question 3.c
             *  la propriété HeureDebut de la classe Prestation pour qu’elle soit obligatoire
             *  et mappée dans une colonne nommée “HeureRDV”.
             */
            builder.Property(p=>p.HeureDebut).IsRequired().HasColumnName("HeureRDV");

        }
    }
}
