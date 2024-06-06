using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdUsuario",
                value: 1);

            migrationBuilder.InsertData(
                table: "Resultados",
                columns: new[] { "Id", "Acertadas", "Completado", "Falladas", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[,]
                {
                    { 2, 27, "Y", 0, 2, 2, 100.0 },
                    { 3, 20, "Y", 7, 3, 3, 74.069999999999993 },
                    { 4, 19, "Y", 8, 4, 4, 70.370000000000005 },
                    { 5, 15, "Y", 12, 5, 5, 55.560000000000002 },
                    { 6, 14, "Y", 13, 6, 6, 51.850000000000001 },
                    { 7, 13, "Y", 14, 7, 7, 48.149999999999999 },
                    { 8, 10, "Y", 17, 8, 8, 37.039999999999999 },
                    { 9, 9, "Y", 18, 9, 9, 33.329999999999998 },
                    { 10, 5, "Y", 22, 10, 10, 18.52 },
                    { 11, 4, "Y", 23, 11, 11, 14.81 },
                    { 12, 3, "Y", 24, 12, 12, 11.109999999999999 },
                    { 13, 2, "Y", 25, 13, 13, 7.4100000000000001 },
                    { 14, 1, "Y", 26, 14, 14, 3.7000000000000002 },
                    { 15, 0, "Y", 27, 15, 15, 0.0 },
                    { 16, 15, "Y", 12, 1, 16, 55.560000000000002 },
                    { 17, 14, "Y", 13, 2, 17, 51.850000000000001 },
                    { 18, 13, "Y", 14, 3, 18, 48.149999999999999 },
                    { 19, 10, "Y", 17, 4, 19, 37.039999999999999 },
                    { 20, 9, "Y", 18, 5, 20, 33.329999999999998 },
                    { 21, 25, "Y", 2, 6, 1, 92.590000000000003 },
                    { 22, 22, "Y", 5, 7, 2, 81.480000000000004 },
                    { 23, 18, "Y", 9, 8, 3, 66.670000000000002 },
                    { 24, 16, "Y", 11, 9, 4, 59.259999999999998 },
                    { 25, 14, "Y", 13, 10, 5, 51.850000000000001 },
                    { 26, 12, "Y", 15, 11, 6, 44.439999999999998 },
                    { 27, 10, "Y", 17, 12, 7, 37.039999999999999 },
                    { 28, 8, "Y", 19, 13, 8, 29.629999999999999 },
                    { 29, 6, "Y", 21, 14, 9, 22.219999999999999 },
                    { 30, 4, "Y", 23, 15, 10, 14.81 },
                    { 31, 3, "Y", 24, 16, 11, 11.109999999999999 },
                    { 32, 2, "Y", 25, 14, 12, 7.4100000000000001 },
                    { 33, 1, "Y", 26, 1, 13, 3.7000000000000002 },
                    { 34, 0, "Y", 27, 3, 14, 0.0 },
                    { 35, 25, "Y", 2, 6, 15, 92.590000000000003 },
                    { 36, 22, "Y", 5, 7, 16, 81.480000000000004 },
                    { 37, 18, "Y", 9, 8, 17, 66.670000000000002 },
                    { 38, 16, "Y", 11, 9, 18, 59.259999999999998 },
                    { 39, 14, "Y", 13, 10, 19, 51.850000000000001 },
                    { 40, 12, "Y", 15, 11, 20, 44.439999999999998 },
                    { 41, 23, "Y", 4, 12, 1, 85.189999999999998 },
                    { 42, 20, "Y", 7, 13, 2, 74.069999999999993 }
                });

            migrationBuilder.InsertData(
                table: "Resultados",
                columns: new[] { "Id", "Acertadas", "Completado", "Falladas", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[,]
                {
                    { 43, 17, "Y", 10, 14, 3, 62.960000000000001 },
                    { 44, 14, "Y", 13, 15, 4, 51.850000000000001 },
                    { 45, 12, "Y", 15, 16, 5, 44.439999999999998 },
                    { 46, 10, "Y", 17, 17, 6, 37.039999999999999 },
                    { 47, 8, "Y", 19, 17, 7, 29.629999999999999 },
                    { 48, 6, "Y", 21, 17, 8, 22.219999999999999 },
                    { 49, 4, "Y", 23, 15, 9, 14.81 },
                    { 50, 3, "Y", 24, 21, 10, 11.109999999999999 },
                    { 51, 2, "Y", 25, 22, 11, 7.4100000000000001 },
                    { 52, 1, "Y", 26, 23, 12, 3.7000000000000002 },
                    { 53, 0, "Y", 27, 24, 13, 0.0 },
                    { 54, 23, "Y", 4, 12, 14, 85.189999999999998 },
                    { 55, 20, "Y", 7, 13, 15, 74.069999999999993 },
                    { 56, 17, "Y", 10, 14, 16, 62.960000000000001 },
                    { 57, 14, "Y", 13, 15, 17, 51.850000000000001 },
                    { 58, 12, "Y", 15, 16, 18, 44.439999999999998 },
                    { 59, 10, "Y", 17, 17, 19, 37.039999999999999 },
                    { 60, 8, "Y", 19, 17, 20, 29.629999999999999 },
                    { 61, 21, "Y", 6, 25, 1, 77.780000000000001 },
                    { 62, 18, "Y", 9, 26, 2, 66.670000000000002 },
                    { 63, 15, "Y", 12, 27, 3, 55.560000000000002 },
                    { 64, 12, "Y", 15, 8, 4, 44.439999999999998 },
                    { 65, 10, "Y", 17, 9, 5, 37.039999999999999 },
                    { 66, 8, "Y", 19, 10, 6, 29.629999999999999 },
                    { 67, 6, "Y", 21, 31, 7, 22.219999999999999 },
                    { 68, 4, "Y", 23, 32, 8, 14.81 },
                    { 69, 3, "Y", 24, 33, 9, 11.109999999999999 },
                    { 70, 2, "Y", 25, 34, 10, 7.4100000000000001 },
                    { 71, 1, "Y", 26, 35, 11, 3.7000000000000002 },
                    { 72, 0, "Y", 27, 36, 12, 0.0 },
                    { 73, 21, "Y", 6, 25, 13, 77.780000000000001 },
                    { 74, 18, "Y", 9, 26, 14, 66.670000000000002 },
                    { 75, 15, "Y", 12, 25, 15, 55.560000000000002 },
                    { 76, 12, "Y", 15, 26, 16, 44.439999999999998 },
                    { 77, 10, "Y", 17, 25, 17, 37.039999999999999 },
                    { 78, 8, "Y", 19, 23, 18, 29.629999999999999 },
                    { 79, 6, "Y", 21, 31, 19, 22.219999999999999 },
                    { 80, 4, "Y", 23, 32, 20, 14.81 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.UpdateData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdUsuario",
                value: 3);
        }
    }
}
