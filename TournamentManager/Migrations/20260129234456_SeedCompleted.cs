using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 10, 14, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados", "TitulosGanados" },
                values: new object[] { 16, 13, 3, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados", "TitulosGanados" },
                values: new object[] { 21, 12, 4, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 10, 11, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosJugados" },
                values: new object[] { 5, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 14, 16, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 15, 16, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 7, 10, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosJugados" },
                values: new object[] { 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados", "TitulosGanados" },
                values: new object[] { 21, 13, 4, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosJugados" },
                values: new object[] { 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 1, 2, 4, 10 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 2, 2, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 2, 3, 1, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 5, 1, 3, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 9, 2, 3, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 2, 3, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 10, 2, 4, 6, 13 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 6, 1, 4, 6, 8 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 2, 5, 1, 4, 6, 6 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 2, 2, 4, 10 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 3, 2, 2, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 3, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 2, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 4, 9, 2, 2, 5, 20 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 4, 3, 2, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 4, 2, 2, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 8, 2, 3, 5, 9 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 3, 3, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 4, 1, 3, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 4, 1, 1, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 2, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 1, 1, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AsistenciasTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 5, 10, 3, 4, 6, 8 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 3, 6, 4, 6, 10 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 4, 5, 1, 4, 6, 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados", "TitulosGanados" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados", "TitulosGanados" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosJugados" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosJugados" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosGanados", "PartidosJugados", "TitulosGanados" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "GolesAFavor", "GolesEnContra", "PartidosJugados" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GolesTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AsistenciasTotales", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AsistenciasTotales", "GolesTotales", "MVPsTotales", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[] { 0, 0, 0, 0, 0, 0 });
        }
    }
}
