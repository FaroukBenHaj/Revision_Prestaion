using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "Clients",
                newName: "Coordonnees_Tel");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Clients",
                newName: "Coordonnees_Prenom");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Clients",
                newName: "Coordonnees_Nom");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Clients",
                newName: "Coordonnees_Adresse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coordonnees_Tel",
                table: "Clients",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "Coordonnees_Prenom",
                table: "Clients",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "Coordonnees_Nom",
                table: "Clients",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Coordonnees_Adresse",
                table: "Clients",
                newName: "Adresse");
        }
    }
}
