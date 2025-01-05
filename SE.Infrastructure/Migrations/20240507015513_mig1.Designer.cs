﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SE.Infrastructure;

#nullable disable

namespace SE.Infrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20240507015513_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SE.ApplicationCore.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Prestataire", b =>
                {
                    b.Property<int>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrestataireId"));

                    b.Property<int>("Appreciation")
                        .HasColumnType("int");

                    b.Property<string>("PrestataireNom")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PrestatairePhoto")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PrestataireTel")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("SpecialiteFK")
                        .HasColumnType("int");

                    b.Property<double>("TarifHoraire")
                        .HasColumnType("float");

                    b.HasKey("PrestataireId");

                    b.HasIndex("SpecialiteFK");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Prestation", b =>
                {
                    b.Property<DateTime>("HeureDebut")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrestataireFK")
                        .HasColumnType("int");

                    b.Property<int>("ClientFK")
                        .HasColumnType("int");

                    b.Property<int>("NbrHeures")
                        .HasColumnType("int");

                    b.HasKey("HeureDebut", "PrestataireFK", "ClientFK");

                    b.HasIndex("ClientFK");

                    b.HasIndex("PrestataireFK");

                    b.ToTable("Prestation");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Specialite", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Intitule")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("Specialites");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Prestataire", b =>
                {
                    b.HasOne("SE.ApplicationCore.Domain.Specialite", "Specialite")
                        .WithMany("Prestataires")
                        .HasForeignKey("SpecialiteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialite");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Prestation", b =>
                {
                    b.HasOne("SE.ApplicationCore.Domain.Client", "Client")
                        .WithMany("Prestations")
                        .HasForeignKey("ClientFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SE.ApplicationCore.Domain.Prestataire", "Prestataire")
                        .WithMany("Prestations")
                        .HasForeignKey("PrestataireFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Prestataire");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Client", b =>
                {
                    b.Navigation("Prestations");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Prestataire", b =>
                {
                    b.Navigation("Prestations");
                });

            modelBuilder.Entity("SE.ApplicationCore.Domain.Specialite", b =>
                {
                    b.Navigation("Prestataires");
                });
#pragma warning restore 612, 618
        }
    }
}
