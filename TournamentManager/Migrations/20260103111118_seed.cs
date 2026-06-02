using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipos",
                columns: new[] { "Id", "GolesAFavor", "GolesEnContra", "Logo", "Nombre", "Pais", "PartidosGanados", "PartidosJugados", "Tag", "TitulosGanados" },
                values: new object[,]
                {
                    { 1, 0, 0, null, "Team BDS", "FR", 0, 0, "BDS", 0 },
                    { 2, 0, 0, null, "G2 Stride", "USA", 0, 0, "G2", 0 },
                    { 3, 0, 0, null, "Karmine Corp", "FR", 0, 0, "KARM", 0 },
                    { 4, 0, 0, null, "Team Falcons", "MENA", 0, 0, "FAL", 0 },
                    { 5, 0, 0, null, "FURIA Esports", "BR", 0, 0, "FUR", 0 },
                    { 6, 0, 0, null, "Oxygen Esports", "USA", 0, 0, "OXG", 0 },
                    { 7, 0, 0, null, "Gentle Mates Alpine", "EU", 0, 0, "GMA", 0 },
                    { 8, 0, 0, null, "Spacestation Gaming", "USA", 0, 0, "SSG", 0 },
                    { 9, 0, 0, null, "NRG Esports", "USA", 0, 0, "NRG", 0 },
                    { 10, 0, 0, null, "Geekay Esports", "EU", 0, 0, "GKAY", 0 },
                    { 11, 0, 0, null, "The Ultimates", "NA", 0, 0, "ULT", 0 },
                    { 12, 0, 0, null, "Wildcard", "OCE", 0, 0, "WC", 0 },
                    { 13, 0, 0, null, "Ninjas in Pyjamas", "EU", 0, 0, "NIP", 0 },
                    { 14, 0, 0, null, "Team Vitality", "FR", 0, 0, "VIT", 0 },
                    { 15, 0, 0, null, "Team Secret", "SAM", 0, 0, "SECR", 0 },
                    { 16, 0, 0, null, "Gen.G Mobil1 Racing", "NA", 0, 0, "GENG", 0 }
                });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "Id", "Edad", "EquipoId", "GolesTotales", "MVPsTotales", "Nick", "Nombre", "Pais", "PartidosGanados", "PartidosJugados" },
                values: new object[,]
                {
                    { 1, 23, 1, 0, 0, "M0nkeyM00n", "Evan \"M0nkey M00n\" Rogez", "FR", 0, 0 },
                    { 2, 24, 1, 0, 0, "ExoTiiK", "Brice \"ExoTiiK\" Bigeard", "FR", 0, 0 },
                    { 3, 24, 14, 0, 0, "zen", "Alexis \"zen\" Bernier", "FR", 0, 0 },
                    { 4, 23, 2, 0, 0, "Atomic", "Atomic", "USA", 0, 0 },
                    { 5, 22, 2, 0, 0, "BeastMode", "Landon \"BeastMode\" Konerman", "USA", 0, 0 },
                    { 6, 20, 2, 0, 0, "Daniel", "Daniel", "USA", 0, 0 },
                    { 7, 25, 3, 0, 0, "Vatira", "Vatira", "BE", 0, 0 },
                    { 8, 24, 3, 0, 0, "Atow", "Atow", "BE", 0, 0 },
                    { 9, 21, 3, 0, 0, "dralii", "dralii", "FR", 0, 0 },
                    { 10, 20, 4, 0, 0, "Trk511", "Trk511", "SA", 0, 0 },
                    { 11, 21, 4, 0, 0, "Rw9", "Rw9", "SA", 0, 0 },
                    { 12, 22, 4, 0, 0, "Kiileerrz", "Kiileerrz", "SA", 0, 0 },
                    { 13, 23, 5, 0, 0, "yANXNZ", "yANXNZ", "BR", 0, 0 },
                    { 14, 24, 5, 0, 0, "Lostt", "Lostt", "BR", 0, 0 },
                    { 15, 22, 5, 0, 0, "DRUFINHO", "DRUFINHO", "BR", 0, 0 },
                    { 16, 23, 6, 0, 0, "OXG_A", "PlayerA_OXG", "USA", 0, 0 },
                    { 17, 22, 6, 0, 0, "OXG_B", "PlayerB_OXG", "USA", 0, 0 },
                    { 18, 21, 6, 0, 0, "OXG_C", "PlayerC_OXG", "USA", 0, 0 },
                    { 19, 22, 7, 0, 0, "Juicy", "Juicy", "FR", 0, 0 },
                    { 20, 23, 7, 0, 0, "Yujin", "Yujin", "KR", 0, 0 },
                    { 21, 21, 7, 0, 0, "Seikoo", "Seikoo", "FR", 0, 0 },
                    { 22, 24, 8, 0, 0, "Scrzbbles", "Scrzbbles", "USA", 0, 0 },
                    { 23, 23, 8, 0, 0, "reveal", "reveal", "USA", 0, 0 },
                    { 24, 22, 8, 0, 0, "kofyr", "kofyr", "USA", 0, 0 },
                    { 25, 23, 9, 0, 0, "Atomic", "Atomic", "USA", 0, 0 },
                    { 26, 22, 9, 0, 0, "BeastMode", "BeastMode", "USA", 0, 0 },
                    { 27, 20, 9, 0, 0, "Daniel", "Daniel", "USA", 0, 0 },
                    { 28, 24, 10, 0, 0, "Archie", "Archie", "EU", 0, 0 },
                    { 29, 23, 10, 0, 0, "Joyo", "Joyo", "EU", 0, 0 },
                    { 30, 22, 10, 0, 0, "Oaly", "Oaly", "EU", 0, 0 },
                    { 31, 25, 11, 0, 0, "Firstkiller", "Firstkiller", "NA", 0, 0 },
                    { 32, 24, 11, 0, 0, "Lj", "Lj", "NA", 0, 0 },
                    { 33, 23, 11, 0, 0, "Chronic", "Chronic", "NA", 0, 0 },
                    { 34, 24, 12, 0, 0, "Fever", "Fever", "OCE", 0, 0 },
                    { 35, 23, 12, 0, 0, "Toros", "Toros", "OCE", 0, 0 },
                    { 36, 22, 12, 0, 0, "Bananahead", "Bananahead", "OCE", 0, 0 },
                    { 37, 23, 13, 0, 0, "NIP1", "PlayerNIP1", "EU", 0, 0 },
                    { 38, 22, 13, 0, 0, "NIP2", "PlayerNIP2", "EU", 0, 0 },
                    { 39, 21, 13, 0, 0, "NIP3", "PlayerNIP3", "EU", 0, 0 },
                    { 40, 23, 15, 0, 0, "kv1", "kv1", "SAM", 0, 0 },
                    { 41, 24, 15, 0, 0, "swiftt", "swiftt", "SAM", 0, 0 },
                    { 42, 22, 15, 0, 0, "Motta", "Motta", "SAM", 0, 0 },
                    { 43, 23, 16, 0, 0, "MaJicBear", "MaJicBear", "NA", 0, 0 },
                    { 44, 24, 16, 0, 0, "CHEESE.", "CHEESE.", "NA", 0, 0 },
                    { 45, 22, 16, 0, 0, "justin.", "justin.", "NA", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
