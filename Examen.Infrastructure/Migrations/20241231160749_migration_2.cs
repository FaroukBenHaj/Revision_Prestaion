using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "Clients",
                newName: "Coordonnes_Tel");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Clients",
                newName: "Coordonnes_Prenom");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Clients",
                newName: "Coordonnes_Nom");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Clients",
                newName: "Coordonnes_Adresse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coordonnes_Tel",
                table: "Clients",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "Coordonnes_Prenom",
                table: "Clients",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "Coordonnes_Nom",
                table: "Clients",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Coordonnes_Adresse",
                table: "Clients",
                newName: "Adresse");
        }
    }
}
