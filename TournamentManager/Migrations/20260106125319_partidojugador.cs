using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class partidojugador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsistenciasTotales",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalvadasTotales",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartidoJugador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goles = table.Column<int>(type: "int", nullable: false),
                    Asistencias = table.Column<int>(type: "int", nullable: false),
                    Salvadas = table.Column<int>(type: "int", nullable: false),
                    Puntuacion = table.Column<int>(type: "int", nullable: false),
                    EquipoPartidoId = table.Column<int>(type: "int", nullable: false),
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartidoJugador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartidoJugador_EquipoPartidos_EquipoPartidoId",
                        column: x => x.EquipoPartidoId,
                        principalTable: "EquipoPartidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartidoJugador_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AsistenciasTotales", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_PartidoJugador_EquipoPartidoId",
                table: "PartidoJugador",
                column: "EquipoPartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidoJugador_JugadorId",
                table: "PartidoJugador",
                column: "JugadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartidoJugador");

            migrationBuilder.DropColumn(
                name: "AsistenciasTotales",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "SalvadasTotales",
                table: "Jugadores");
        }
    }
}
