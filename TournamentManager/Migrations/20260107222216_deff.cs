using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class deff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartidoJugador_EquipoPartidos_EquipoPartidoId",
                table: "PartidoJugador");

            migrationBuilder.DropForeignKey(
                name: "FK_PartidoJugador_Jugadores_JugadorId",
                table: "PartidoJugador");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartidoJugador",
                table: "PartidoJugador");

            migrationBuilder.RenameTable(
                name: "PartidoJugador",
                newName: "PartidoJugadores");

            migrationBuilder.RenameIndex(
                name: "IX_PartidoJugador_JugadorId",
                table: "PartidoJugadores",
                newName: "IX_PartidoJugadores_JugadorId");

            migrationBuilder.RenameIndex(
                name: "IX_PartidoJugador_EquipoPartidoId",
                table: "PartidoJugadores",
                newName: "IX_PartidoJugadores_EquipoPartidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartidoJugadores",
                table: "PartidoJugadores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartidoJugadores_EquipoPartidos_EquipoPartidoId",
                table: "PartidoJugadores",
                column: "EquipoPartidoId",
                principalTable: "EquipoPartidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartidoJugadores_Jugadores_JugadorId",
                table: "PartidoJugadores",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartidoJugadores_EquipoPartidos_EquipoPartidoId",
                table: "PartidoJugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_PartidoJugadores_Jugadores_JugadorId",
                table: "PartidoJugadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartidoJugadores",
                table: "PartidoJugadores");

            migrationBuilder.RenameTable(
                name: "PartidoJugadores",
                newName: "PartidoJugador");

            migrationBuilder.RenameIndex(
                name: "IX_PartidoJugadores_JugadorId",
                table: "PartidoJugador",
                newName: "IX_PartidoJugador_JugadorId");

            migrationBuilder.RenameIndex(
                name: "IX_PartidoJugadores_EquipoPartidoId",
                table: "PartidoJugador",
                newName: "IX_PartidoJugador_EquipoPartidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartidoJugador",
                table: "PartidoJugador",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartidoJugador_EquipoPartidos_EquipoPartidoId",
                table: "PartidoJugador",
                column: "EquipoPartidoId",
                principalTable: "EquipoPartidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartidoJugador_Jugadores_JugadorId",
                table: "PartidoJugador",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
