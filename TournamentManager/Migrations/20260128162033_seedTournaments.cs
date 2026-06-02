using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class seedTournaments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Torneos",
                columns: new[] { "Id", "CampeonId", "Estado", "FechaFin", "FechaInicio", "MVPId", "Nombre" },
                values: new object[,]
                {
                    { 1, 14, 2, new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, "RLCS 2023 World Championship" },
                    { 2, 2, 2, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "RLCS 2024 Major 1" },
                    { 3, 3, 2, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "RLCS 2025 Winter Split" }
                });

            migrationBuilder.InsertData(
                table: "EquipoTorneos",
                columns: new[] { "Id", "EquipoId", "Estado", "PosicionFinal", "TorneoId" },
                values: new object[,]
                {
                    { 1, 14, 2, 1, 1 },
                    { 2, 1, 1, 2, 1 },
                    { 3, 2, 2, 1, 2 },
                    { 4, 4, 1, 2, 2 },
                    { 5, 3, 2, 1, 3 },
                    { 6, 7, 1, 2, 3 },
                    { 100, 6, 1, 3, 1 },
                    { 101, 3, 1, 3, 1 },
                    { 200, 6, 1, 5, 2 },
                    { 300, 6, 1, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Rondas",
                columns: new[] { "Id", "Nombre", "TorneoId" },
                values: new object[,]
                {
                    { 1, "Gran Final", 1 },
                    { 2, "Gran Final", 2 },
                    { 3, "Gran Final", 3 },
                    { 10, "Cuartos de Final", 1 },
                    { 11, "Semifinales", 1 },
                    { 20, "Cuartos de Final", 2 },
                    { 21, "Semifinales", 2 },
                    { 30, "Cuartos de Final", 3 },
                    { 31, "Semifinales", 3 }
                });

            migrationBuilder.InsertData(
                table: "Partidos",
                columns: new[] { "Id", "Jugado", "MVPJugadorId", "RondaId" },
                values: new object[,]
                {
                    { 1, true, 46, 1 },
                    { 2, true, 5, 2 },
                    { 3, true, 7, 3 },
                    { 101, true, 46, 10 },
                    { 102, true, 16, 10 },
                    { 103, true, 1, 10 },
                    { 104, true, 7, 10 },
                    { 105, true, 46, 11 },
                    { 106, true, 1, 11 },
                    { 201, true, 5, 20 },
                    { 202, true, 19, 20 },
                    { 203, true, 10, 20 },
                    { 204, true, 25, 20 },
                    { 205, true, 6, 21 },
                    { 206, true, 11, 21 },
                    { 301, true, 7, 30 },
                    { 302, true, 16, 30 },
                    { 303, true, 19, 30 },
                    { 304, true, 46, 30 },
                    { 305, true, 7, 31 },
                    { 306, true, 21, 31 }
                });

            migrationBuilder.InsertData(
                table: "EquipoPartidos",
                columns: new[] { "Id", "EquipoId", "Goles", "PartidoId" },
                values: new object[,]
                {
                    { 1, 14, 4, 1 },
                    { 2, 1, 0, 1 },
                    { 3, 2, 4, 2 },
                    { 4, 4, 1, 2 },
                    { 5, 3, 4, 3 },
                    { 6, 7, 3, 3 },
                    { 1010, 14, 4, 101 },
                    { 1011, 9, 1, 101 },
                    { 1020, 6, 4, 102 },
                    { 1021, 5, 2, 102 },
                    { 1030, 1, 4, 103 },
                    { 1031, 2, 3, 103 },
                    { 1040, 3, 4, 104 },
                    { 1041, 4, 0, 104 },
                    { 1050, 14, 4, 105 },
                    { 1051, 6, 2, 105 },
                    { 1060, 1, 4, 106 },
                    { 1061, 3, 3, 106 },
                    { 2010, 2, 4, 201 },
                    { 2011, 6, 3, 201 },
                    { 2020, 7, 4, 202 },
                    { 2021, 14, 2, 202 },
                    { 2030, 4, 4, 203 },
                    { 2031, 1, 1, 203 },
                    { 2040, 9, 4, 204 },
                    { 2041, 3, 2, 204 },
                    { 2050, 2, 4, 205 },
                    { 2051, 7, 0, 205 },
                    { 2060, 4, 4, 206 },
                    { 2061, 9, 2, 206 },
                    { 3010, 3, 4, 301 },
                    { 3011, 13, 0, 301 },
                    { 3020, 6, 4, 302 },
                    { 3021, 16, 2, 302 },
                    { 3030, 7, 4, 303 },
                    { 3031, 5, 3, 303 },
                    { 3040, 14, 4, 304 },
                    { 3041, 2, 1, 304 },
                    { 3050, 3, 4, 305 },
                    { 3051, 6, 1, 305 },
                    { 3060, 7, 4, 306 },
                    { 3061, 14, 3, 306 }
                });

            migrationBuilder.InsertData(
                table: "PartidoJugadores",
                columns: new[] { "Id", "Asistencias", "EquipoPartidoId", "Goles", "JugadorId", "Puntuacion", "Salvadas" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, 46, 650, 1 },
                    { 2, 1, 1, 1, 47, 450, 2 },
                    { 3, 2, 1, 1, 48, 500, 1 },
                    { 4, 0, 2, 0, 1, 380, 4 },
                    { 5, 0, 2, 0, 2, 220, 2 },
                    { 6, 0, 2, 1, 3, 340, 1 },
                    { 7, 2, 3, 1, 4, 580, 2 },
                    { 8, 0, 3, 3, 5, 820, 1 },
                    { 9, 3, 3, 0, 6, 500, 1 },
                    { 10, 0, 4, 1, 10, 450, 3 },
                    { 11, 1, 4, 0, 11, 300, 2 },
                    { 12, 0, 4, 1, 12, 350, 1 },
                    { 13, 1, 5, 2, 7, 900, 4 },
                    { 14, 2, 5, 1, 8, 600, 2 },
                    { 15, 1, 5, 1, 9, 550, 1 },
                    { 16, 0, 6, 2, 19, 620, 1 },
                    { 17, 2, 6, 0, 20, 480, 3 },
                    { 18, 1, 6, 1, 21, 510, 2 },
                    { 100, 1, 1020, 3, 16, 850, 4 },
                    { 101, 2, 1020, 1, 17, 400, 1 },
                    { 102, 1, 1020, 0, 18, 320, 3 },
                    { 103, 0, 1051, 1, 16, 680, 6 },
                    { 104, 1, 2011, 2, 16, 710, 3 },
                    { 105, 1, 2011, 0, 17, 250, 1 },
                    { 106, 1, 2010, 3, 5, 800, 2 },
                    { 107, 2, 3020, 2, 16, 750, 2 },
                    { 108, 0, 3051, 1, 16, 550, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3040);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3041);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3050);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3060);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3061);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "EquipoTorneos",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 3051);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Partidos",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rondas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Torneos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Torneos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Torneos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
