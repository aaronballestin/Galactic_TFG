using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resultados",
                columns: new[] { "Id", "Acertadas", "Completado", "Falladas", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[,]
                {
                    { 81, 25, "Y", 2, 51, 1, 92.590000000000003 },
                    { 82, 24, "Y", 3, 52, 2, 88.890000000000001 },
                    { 83, 23, "Y", 4, 53, 3, 85.189999999999998 },
                    { 84, 22, "Y", 5, 54, 4, 81.480000000000004 },
                    { 85, 21, "Y", 6, 55, 5, 77.780000000000001 },
                    { 86, 20, "Y", 7, 56, 6, 74.069999999999993 },
                    { 87, 19, "Y", 8, 57, 7, 70.370000000000005 },
                    { 88, 18, "Y", 9, 51, 8, 66.670000000000002 },
                    { 89, 17, "Y", 10, 52, 9, 62.960000000000001 },
                    { 90, 16, "Y", 11, 53, 10, 59.259999999999998 },
                    { 91, 15, "Y", 12, 54, 11, 55.560000000000002 },
                    { 92, 14, "Y", 13, 55, 12, 51.850000000000001 },
                    { 93, 13, "Y", 14, 56, 13, 48.149999999999999 },
                    { 94, 12, "Y", 15, 57, 14, 44.439999999999998 },
                    { 95, 11, "Y", 16, 51, 15, 40.740000000000002 },
                    { 96, 10, "Y", 17, 52, 16, 37.039999999999999 },
                    { 97, 9, "Y", 18, 53, 17, 33.329999999999998 },
                    { 98, 8, "Y", 19, 54, 18, 29.629999999999999 },
                    { 99, 7, "Y", 20, 55, 19, 25.93 },
                    { 100, 6, "Y", 21, 56, 20, 22.219999999999999 },
                    { 101, 25, "Y", 2, 41, 1, 92.590000000000003 },
                    { 102, 24, "Y", 3, 42, 2, 88.890000000000001 },
                    { 103, 23, "Y", 4, 43, 3, 85.189999999999998 },
                    { 104, 22, "Y", 5, 44, 4, 81.480000000000004 },
                    { 105, 21, "Y", 6, 45, 5, 77.780000000000001 },
                    { 106, 20, "Y", 7, 46, 6, 74.069999999999993 },
                    { 107, 19, "Y", 8, 47, 7, 70.370000000000005 },
                    { 108, 18, "Y", 9, 41, 8, 66.670000000000002 },
                    { 109, 17, "Y", 10, 42, 9, 62.960000000000001 },
                    { 110, 16, "Y", 11, 43, 10, 59.259999999999998 },
                    { 111, 15, "Y", 12, 44, 11, 55.560000000000002 },
                    { 112, 14, "Y", 13, 45, 12, 51.850000000000001 },
                    { 113, 13, "Y", 14, 46, 13, 48.149999999999999 },
                    { 114, 12, "Y", 15, 47, 14, 44.439999999999998 },
                    { 115, 11, "Y", 16, 41, 15, 40.740000000000002 },
                    { 116, 10, "Y", 17, 42, 16, 37.039999999999999 },
                    { 117, 9, "Y", 18, 43, 17, 33.329999999999998 },
                    { 118, 8, "Y", 19, 44, 18, 29.629999999999999 },
                    { 119, 7, "Y", 20, 45, 19, 25.93 },
                    { 120, 6, "Y", 21, 46, 20, 22.219999999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 120);
        }
    }
}
