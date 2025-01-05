using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Specialites",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitule = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialites", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Prestataires",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrestataireNom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PrestatairePhoto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PrestataireTel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Appreciation = table.Column<int>(type: "int", nullable: false),
                    TarifHoraire = table.Column<double>(type: "float", nullable: false),
                    SpecialiteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataires", x => x.PrestataireId);
                    table.ForeignKey(
                        name: "FK_Prestataires_Specialites_SpecialiteFK",
                        column: x => x.SpecialiteFK,
                        principalTable: "Specialites",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestation",
                columns: table => new
                {
                    HeureDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientFK = table.Column<int>(type: "int", nullable: false),
                    PrestataireFK = table.Column<int>(type: "int", nullable: false),
                    NbrHeures = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestation", x => new { x.HeureDebut, x.PrestataireFK, x.ClientFK });
                    table.ForeignKey(
                        name: "FK_Prestation_Clients_ClientFK",
                        column: x => x.ClientFK,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestation_Prestataires_PrestataireFK",
                        column: x => x.PrestataireFK,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestataires_SpecialiteFK",
                table: "Prestataires",
                column: "SpecialiteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Prestation_ClientFK",
                table: "Prestation",
                column: "ClientFK");

            migrationBuilder.CreateIndex(
                name: "IX_Prestation_PrestataireFK",
                table: "Prestation",
                column: "PrestataireFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestation");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Prestataires");

            migrationBuilder.DropTable(
                name: "Specialites");
        }
    }
}
