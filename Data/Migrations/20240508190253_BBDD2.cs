using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasapalabraId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasapalabraId",
                value: 2);
        }
    }
}
