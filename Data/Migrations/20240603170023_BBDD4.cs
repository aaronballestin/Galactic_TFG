using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 60);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Codigo", "IdAsignatura", "IdCurso", "IdTipoJuego", "TemaJuego" },
                values: new object[,]
                {
                    { 18, "XXXXXX", 1, 2, 1, "Lengua - 2" },
                    { 19, "XXXXXX", 4, 2, 1, "Plastica" },
                    { 20, "XXXXXX", 4, 2, 1, "Musica" },
                    { 28, "XXXXXX", 1, 3, 1, "Lengua - 2" },
                    { 29, "XXXXXX", 4, 3, 1, "Plastica" },
                    { 30, "XXXXXX", 4, 3, 1, "Musica" },
                    { 38, "XXXXXX", 1, 4, 1, "Lengua - 2" },
                    { 39, "XXXXXX", 4, 4, 1, "Plastica" },
                    { 40, "XXXXXX", 4, 4, 1, "Musica" },
                    { 48, "XXXXXX", 1, 5, 1, "Lengua - 2" },
                    { 49, "XXXXXX", 4, 5, 1, "Plastica" },
                    { 50, "XXXXXX", 4, 5, 1, "Musica" },
                    { 58, "XXXXXX", 1, 6, 1, "Lengua - 2" },
                    { 59, "XXXXXX", 4, 6, 1, "Plastica" },
                    { 60, "XXXXXX", 4, 6, 1, "Musica" }
                });
        }
    }
}
