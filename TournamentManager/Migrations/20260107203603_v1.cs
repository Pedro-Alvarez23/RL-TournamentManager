using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Logo",
                value: "https://upload.wikimedia.org/wikipedia/fr/6/61/Team_BDS.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "https://liquipedia.net/commons/images/d/d3/G2_Esports_2019_lightmode.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Logo",
                value: "https://upload.wikimedia.org/wikipedia/commons/9/96/Karmine_Corp_logo.svg");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Logo",
                value: "https://cdn.freebiesupply.com/images/thumbs/2x/atlanta-falcons-logo.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Logo",
                value: "https://vectorseek.com/wp-content/uploads/2023/04/Furia-Esports-Logo-Vector.jpg");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Logo",
                value: "https://liquipedia.net/commons/images/f/f9/Oxygen_Esports_2021_allmode.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Logo",
                value: "https://upload.wikimedia.org/wikipedia/commons/b/be/Gentle_Mates_2025.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Logo",
                value: "https://cdn.prod.website-files.com/605e2c8c6b591c8ec12559d4/67db0453ffa840b313729e7f_1000x1000.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Logo",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQn2Cur13GkniLAl7dqZrfKjvKo3LH0iO9P5A&s");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Logo",
                value: "https://liquipedia.net/commons/images/f/f1/Geekay_Esports_2023_allmode.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Logo",
                value: "https://liquipedia.net/commons/images/8/80/The_Ultimates_2020_allmode.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Logo",
                value: "https://www.clipartmax.com/png/middle/100-1001205_wildcard-gaminglogo-square-wildcard-gaming.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Logo",
                value: "https://images.seeklogo.com/logo-png/55/2/ninjas-in-pyjamas-logo-png_seeklogo-550433.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Logo",
                value: "https://www.vhv.rs/dpng/d/487-4879695_team-vitality-cs-team-vitality-logo-hd-png.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Logo",
                value: "https://upload.wikimedia.org/wikipedia/ru/archive/7/71/20230415191739%21Team_Secret_logo_notext.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Logo",
                value: "https://upload.wikimedia.org/wikipedia/commons/7/77/Gen.G_Logo.svg");

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 21, "alfredbg333", "Alfredo Blanco", "ES" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 24, "SquishyMuffinz", "Mariano Arruda", "CA" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Edad", "Nick", "Nombre" },
                values: new object[] { 27, "Rizzo", "Dillon Rizzo" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Edad", "Nick", "Nombre" },
                values: new object[] { 24, "GarrettG", "Garrett Gordon" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Edad", "Nick", "Nombre" },
                values: new object[] { 23, "jstn.", "Justin Morales" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 24, "Squishy", "Mariano Arruda", "CA" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 21, "AztromicK", "Luiz Fellipe", "BR" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Nick", "Nombre", "Pais" },
                values: new object[] { "Bemmz", "Bernardo Siqueira", "BR" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 25, "CaioTG1", "Caio Vinicius", "BR" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Nick", "Nombre", "Pais" },
                values: new object[] { "crr", "Cristian", "ES" });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "Id", "AsistenciasTotales", "Edad", "EquipoId", "GolesTotales", "MVPsTotales", "Nick", "Nombre", "Pais", "PartidosGanados", "PartidosJugados", "SalvadasTotales" },
                values: new object[,]
                {
                    { 46, 0, 22, 14, 0, 0, "Alpha54", "Yanis Champenois", "FR", 0, 0, 0 },
                    { 47, 0, 21, 14, 0, 0, "Radosin", "Andrea Radovanović", "FR", 0, 0, 0 },
                    { 48, 0, 26, 14, 0, 0, "Fairy Peak!", "Victor Locquet", "FR", 0, 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 23, "OXG_A", "PlayerA_OXG", "USA" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 22, "OXG_B", "PlayerB_OXG", "USA" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Edad", "Nick", "Nombre" },
                values: new object[] { 21, "OXG_C", "PlayerC_OXG" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Edad", "Nick", "Nombre" },
                values: new object[] { 23, "Atomic", "Atomic" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Edad", "Nick", "Nombre" },
                values: new object[] { 22, "BeastMode", "BeastMode" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 20, "Daniel", "Daniel", "USA" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 23, "NIP1", "PlayerNIP1", "EU" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Nick", "Nombre", "Pais" },
                values: new object[] { "NIP2", "PlayerNIP2", "EU" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Edad", "Nick", "Nombre", "Pais" },
                values: new object[] { 21, "NIP3", "PlayerNIP3", "EU" });

            migrationBuilder.UpdateData(
                table: "Jugadores",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Nick", "Nombre", "Pais" },
                values: new object[] { "justin.", "justin.", "NA" });
        }
    }
}
