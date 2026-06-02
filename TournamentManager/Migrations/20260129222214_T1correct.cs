using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class T1correct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Goles",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Goles",
                value: 2);

            migrationBuilder.InsertData(
                table: "PartidoJugadores",
                columns: new[] { "Id", "Asistencias", "EquipoPartidoId", "Goles", "JugadorId", "Puntuacion", "Salvadas" },
                values: new object[,]
                {
                    { 109, 1, 1010, 2, 46, 700, 1 },
                    { 110, 1, 1010, 1, 47, 500, 2 },
                    { 111, 0, 1010, 1, 48, 450, 1 },
                    { 112, 0, 1011, 1, 25, 420, 2 },
                    { 113, 0, 1011, 0, 26, 300, 1 },
                    { 114, 0, 1011, 0, 27, 280, 1 },
                    { 115, 0, 1030, 2, 1, 680, 2 },
                    { 116, 1, 1030, 1, 2, 520, 1 },
                    { 117, 1, 1030, 1, 3, 510, 1 },
                    { 118, 1, 1031, 1, 4, 480, 1 },
                    { 119, 0, 1031, 1, 5, 500, 2 },
                    { 120, 0, 1031, 1, 6, 460, 1 },
                    { 121, 1, 1040, 2, 7, 720, 1 },
                    { 122, 1, 1040, 1, 8, 600, 2 },
                    { 123, 0, 1040, 1, 9, 540, 1 },
                    { 124, 0, 1041, 0, 10, 350, 3 },
                    { 125, 0, 1041, 0, 11, 300, 2 },
                    { 126, 0, 1041, 0, 12, 260, 1 },
                    { 127, 0, 1021, 1, 13, 420, 2 },
                    { 128, 1, 1021, 1, 14, 400, 1 },
                    { 129, 0, 1021, 0, 15, 300, 1 },
                    { 130, 1, 1050, 2, 46, 720, 1 },
                    { 131, 1, 1050, 1, 47, 520, 2 },
                    { 132, 0, 1050, 1, 48, 480, 1 },
                    { 133, 0, 1051, 1, 17, 360, 2 },
                    { 134, 1, 1051, 0, 18, 300, 1 },
                    { 135, 0, 1060, 2, 1, 680, 2 },
                    { 136, 1, 1060, 1, 2, 520, 1 },
                    { 137, 1, 1060, 1, 3, 500, 1 },
                    { 138, 1, 1061, 1, 7, 560, 2 },
                    { 139, 0, 1061, 1, 8, 480, 1 },
                    { 140, 0, 1061, 1, 9, 460, 1 },
                    { 141, 1, 2010, 1, 4, 520, 1 },
                    { 142, 1, 2010, 0, 6, 400, 2 },
                    { 999, 1, 2011, 1, 18, 250, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.UpdateData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Goles",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EquipoPartidos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Goles",
                value: 1);
        }
    }
}
