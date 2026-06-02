using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentManager.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "https://cdn.fifa.gg/cache/media/team_emblem/51c3f5a8-f4e3-42f7-8793-a23806b9d41e/Emblem-of-team-G2-Stride-team_emblem-51c3f5a8-f4e3-42f7-8793-a23806b9d41e.png?");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Logo",
                value: "https://esportsinsider.com/wp-content/uploads/2023/07/oxygen-esports-new-logo-new.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Logo",
                value: "https://distribution.faceit-cdn.net/images/e146675f-058d-468a-a9be-4640caaaf09a.jpg");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Logo",
                value: "https://images.squarespace-cdn.com/content/v1/531ced34e4b0f6dda98cdae8/1395639361432-7DQAQN747X1H99QTKFIN/KyleChristianDesign_Logo_UFC_Ultimates_4C.jpg?format=1500w");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Logo",
                value: "https://liquipedia.net/commons/images/d/d3/G2_Esports_2019_lightmode.png");

            migrationBuilder.UpdateData(
                table: "Equipos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Logo",
                value: "https://liquipedia.net/commons/images/f/f9/Oxygen_Esports_2021_allmode.png");

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
        }
    }
}
