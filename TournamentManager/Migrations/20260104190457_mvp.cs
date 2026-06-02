using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class mvp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MVPJugadorId",
                table: "Partidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_MVPJugadorId",
                table: "Partidos",
                column: "MVPJugadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Jugadores_MVPJugadorId",
                table: "Partidos",
                column: "MVPJugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Jugadores_MVPJugadorId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_MVPJugadorId",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "MVPJugadorId",
                table: "Partidos");
        }
    }
}
