using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class TsCorrect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PartidoJugadores",
                columns: new[] { "Id", "Asistencias", "EquipoPartidoId", "Goles", "JugadorId", "Puntuacion", "Salvadas" },
                values: new object[,]
                {
                    { 143, 0, 2020, 2, 19, 650, 2 },
                    { 144, 1, 2020, 1, 20, 500, 1 },
                    { 145, 0, 2020, 1, 21, 480, 1 },
                    { 146, 0, 2021, 1, 46, 480, 2 },
                    { 147, 0, 2021, 1, 47, 420, 1 },
                    { 148, 1, 2021, 0, 48, 360, 1 },
                    { 149, 0, 2030, 2, 10, 620, 2 },
                    { 150, 1, 2030, 1, 11, 500, 1 },
                    { 151, 0, 2030, 1, 12, 480, 1 },
                    { 152, 0, 2031, 1, 1, 420, 2 },
                    { 153, 0, 2031, 0, 2, 300, 1 },
                    { 154, 0, 2031, 0, 3, 280, 1 },
                    { 155, 0, 2040, 2, 25, 620, 2 },
                    { 156, 1, 2040, 1, 26, 500, 1 },
                    { 157, 0, 2040, 1, 27, 480, 1 },
                    { 158, 0, 2041, 1, 7, 460, 2 },
                    { 159, 0, 2041, 1, 8, 420, 1 },
                    { 160, 1, 2041, 0, 9, 380, 1 },
                    { 161, 1, 2050, 1, 4, 520, 2 },
                    { 162, 0, 2050, 2, 5, 700, 1 },
                    { 163, 1, 2050, 1, 6, 500, 1 },
                    { 164, 0, 2051, 0, 19, 320, 2 },
                    { 165, 0, 2051, 0, 20, 280, 1 },
                    { 166, 0, 2051, 0, 21, 260, 1 },
                    { 167, 0, 2060, 2, 10, 620, 2 },
                    { 168, 1, 2060, 1, 11, 500, 1 },
                    { 169, 0, 2060, 1, 12, 480, 1 },
                    { 170, 0, 2061, 1, 25, 450, 2 },
                    { 171, 0, 2061, 1, 26, 420, 1 },
                    { 172, 1, 2061, 0, 27, 380, 1 },
                    { 173, 1, 3010, 2, 7, 720, 2 },
                    { 174, 1, 3010, 1, 8, 560, 1 },
                    { 175, 0, 3010, 1, 9, 520, 1 },
                    { 176, 0, 3011, 0, 37, 300, 2 },
                    { 177, 0, 3011, 0, 38, 260, 1 },
                    { 178, 0, 3011, 0, 39, 240, 1 },
                    { 179, 1, 3020, 1, 17, 480, 1 },
                    { 180, 0, 3020, 1, 18, 420, 1 },
                    { 181, 0, 3021, 1, 43, 460, 2 },
                    { 182, 0, 3021, 1, 44, 420, 1 },
                    { 183, 1, 3021, 0, 45, 380, 1 },
                    { 184, 0, 3030, 2, 19, 640, 2 },
                    { 185, 1, 3030, 1, 20, 520, 1 },
                    { 186, 0, 3030, 1, 21, 500, 1 },
                    { 187, 0, 3031, 1, 13, 460, 2 },
                    { 188, 1, 3031, 1, 14, 480, 1 },
                    { 189, 0, 3031, 1, 15, 440, 1 },
                    { 190, 1, 3040, 2, 46, 700, 1 },
                    { 191, 0, 3040, 1, 47, 520, 2 },
                    { 192, 1, 3040, 1, 48, 540, 1 },
                    { 193, 0, 3041, 1, 4, 420, 2 },
                    { 194, 0, 3041, 0, 5, 300, 1 },
                    { 195, 0, 3041, 0, 6, 280, 1 },
                    { 196, 1, 3050, 2, 7, 720, 2 },
                    { 197, 1, 3050, 1, 8, 560, 1 },
                    { 198, 0, 3050, 1, 9, 520, 1 },
                    { 199, 0, 3051, 0, 17, 320, 2 },
                    { 200, 1, 3051, 0, 18, 300, 1 },
                    { 201, 0, 3060, 2, 19, 640, 2 },
                    { 202, 1, 3060, 1, 20, 520, 1 },
                    { 203, 0, 3060, 1, 21, 500, 1 },
                    { 204, 1, 3061, 1, 46, 560, 2 },
                    { 205, 0, 3061, 1, 47, 480, 1 },
                    { 206, 0, 3061, 1, 48, 460, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "PartidoJugadores",
                keyColumn: "Id",
                keyValue: 206);
        }
    }
}
