using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestation_Clients_ClientFK",
                table: "Prestation");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestation_Prestataires_PrestataireFK",
                table: "Prestation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestation",
                table: "Prestation");

            migrationBuilder.RenameTable(
                name: "Prestation",
                newName: "Prestations");

            migrationBuilder.RenameIndex(
                name: "IX_Prestation_PrestataireFK",
                table: "Prestations",
                newName: "IX_Prestations_PrestataireFK");

            migrationBuilder.RenameIndex(
                name: "IX_Prestation_ClientFK",
                table: "Prestations",
                newName: "IX_Prestations_ClientFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestations",
                table: "Prestations",
                columns: new[] { "HeureDebut", "PrestataireFK", "ClientFK" });

            migrationBuilder.AddForeignKey(
                name: "FK_Prestations_Clients_ClientFK",
                table: "Prestations",
                column: "ClientFK",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestations_Prestataires_PrestataireFK",
                table: "Prestations",
                column: "PrestataireFK",
                principalTable: "Prestataires",
                principalColumn: "PrestataireId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestations_Clients_ClientFK",
                table: "Prestations");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestations_Prestataires_PrestataireFK",
                table: "Prestations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestations",
                table: "Prestations");

            migrationBuilder.RenameTable(
                name: "Prestations",
                newName: "Prestation");

            migrationBuilder.RenameIndex(
                name: "IX_Prestations_PrestataireFK",
                table: "Prestation",
                newName: "IX_Prestation_PrestataireFK");

            migrationBuilder.RenameIndex(
                name: "IX_Prestations_ClientFK",
                table: "Prestation",
                newName: "IX_Prestation_ClientFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestation",
                table: "Prestation",
                columns: new[] { "HeureDebut", "PrestataireFK", "ClientFK" });

            migrationBuilder.AddForeignKey(
                name: "FK_Prestation_Clients_ClientFK",
                table: "Prestation",
                column: "ClientFK",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestation_Prestataires_PrestataireFK",
                table: "Prestation",
                column: "PrestataireFK",
                principalTable: "Prestataires",
                principalColumn: "PrestataireId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
