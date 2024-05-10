using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignaturaJuegos_Asignaturas_IdAsignatura",
                table: "AsignaturaJuegos");

            migrationBuilder.DropForeignKey(
                name: "FK_AsignaturaJuegos_TipoJuegos_IdTipoJuego",
                table: "AsignaturaJuegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Cursos_CursoId",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_AsignaturaJuegos_IdAsignaturaJuego",
                table: "Juegos");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_CursoId",
                table: "Asignaturas");

            migrationBuilder.DropIndex(
                name: "IX_AsignaturaJuegos_IdAsignatura",
                table: "AsignaturaJuegos");

            migrationBuilder.DropIndex(
                name: "IX_AsignaturaJuegos_IdTipoJuego",
                table: "AsignaturaJuegos");

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AsignaturaJuegos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Asignaturas");

            migrationBuilder.RenameColumn(
                name: "IdAsignaturaJuego",
                table: "Juegos",
                newName: "IdTipoJuego");

            migrationBuilder.RenameIndex(
                name: "IX_Juegos_IdAsignaturaJuego",
                table: "Juegos",
                newName: "IX_Juegos_IdTipoJuego");

            migrationBuilder.AddColumn<int>(
                name: "AsignaturaJuegoId",
                table: "Juegos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAsignatura",
                table: "Juegos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCurso",
                table: "Juegos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AsignaturaId",
                table: "AsignaturaJuegos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoJuegoId",
                table: "AsignaturaJuegos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdAsignatura", "IdCurso" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdAsignatura", "IdCurso" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_AsignaturaJuegoId",
                table: "Juegos",
                column: "AsignaturaJuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdAsignatura",
                table: "Juegos",
                column: "IdAsignatura");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdCurso",
                table: "Juegos",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_AsignaturaId",
                table: "AsignaturaJuegos",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_TipoJuegoId",
                table: "AsignaturaJuegos",
                column: "TipoJuegoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignaturaJuegos_Asignaturas_AsignaturaId",
                table: "AsignaturaJuegos",
                column: "AsignaturaId",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignaturaJuegos_TipoJuegos_TipoJuegoId",
                table: "AsignaturaJuegos",
                column: "TipoJuegoId",
                principalTable: "TipoJuegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_AsignaturaJuegos_AsignaturaJuegoId",
                table: "Juegos",
                column: "AsignaturaJuegoId",
                principalTable: "AsignaturaJuegos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Asignaturas_IdAsignatura",
                table: "Juegos",
                column: "IdAsignatura",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Cursos_IdCurso",
                table: "Juegos",
                column: "IdCurso",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_TipoJuegos_IdTipoJuego",
                table: "Juegos",
                column: "IdTipoJuego",
                principalTable: "TipoJuegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignaturaJuegos_Asignaturas_AsignaturaId",
                table: "AsignaturaJuegos");

            migrationBuilder.DropForeignKey(
                name: "FK_AsignaturaJuegos_TipoJuegos_TipoJuegoId",
                table: "AsignaturaJuegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_AsignaturaJuegos_AsignaturaJuegoId",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Asignaturas_IdAsignatura",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Cursos_IdCurso",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_TipoJuegos_IdTipoJuego",
                table: "Juegos");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_AsignaturaJuegoId",
                table: "Juegos");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_IdAsignatura",
                table: "Juegos");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_IdCurso",
                table: "Juegos");

            migrationBuilder.DropIndex(
                name: "IX_AsignaturaJuegos_AsignaturaId",
                table: "AsignaturaJuegos");

            migrationBuilder.DropIndex(
                name: "IX_AsignaturaJuegos_TipoJuegoId",
                table: "AsignaturaJuegos");

            migrationBuilder.DropColumn(
                name: "AsignaturaJuegoId",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "IdAsignatura",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "IdCurso",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "AsignaturaId",
                table: "AsignaturaJuegos");

            migrationBuilder.DropColumn(
                name: "TipoJuegoId",
                table: "AsignaturaJuegos");

            migrationBuilder.RenameColumn(
                name: "IdTipoJuego",
                table: "Juegos",
                newName: "IdAsignaturaJuego");

            migrationBuilder.RenameIndex(
                name: "IX_Juegos_IdTipoJuego",
                table: "Juegos",
                newName: "IX_Juegos_IdAsignaturaJuego");

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Asignaturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AsignaturaJuegos",
                columns: new[] { "Id", "IdAsignatura", "IdTipoJuego", "JuegoAsignatura" },
                values: new object[,]
                {
                    { 1, 1, 1, "Pasapalabra Lengua 1º" },
                    { 2, 6, 1, "Pasapalabra Lengua 2º" },
                    { 3, 11, 1, "Pasapalabra Lengua 3º" },
                    { 4, 16, 1, "Pasapalabra Lengua 4º" },
                    { 5, 21, 1, "Pasapalabra Lengua 5º" },
                    { 6, 26, 1, "Pasapalabra Lengua 6º" },
                    { 7, 2, 1, "Pasapalabra Matematicas 1º" },
                    { 8, 7, 1, "Pasapalabra Matematicas 2º" },
                    { 9, 12, 1, "Pasapalabra Matematicas 3º" },
                    { 10, 17, 1, "Pasapalabra Matematicas 4º" },
                    { 11, 22, 1, "Pasapalabra Matematicas 5º" },
                    { 12, 27, 1, "Pasapalabra Matematicas 6º" },
                    { 13, 3, 1, "Pasapalabra Conocimiento del medio 1º" },
                    { 14, 8, 1, "Pasapalabra Conocimiento del medio 2º" },
                    { 15, 13, 1, "Pasapalabra Conocimiento del medio 3º" },
                    { 16, 18, 1, "Pasapalabra Conocimiento del medio 4º" },
                    { 17, 23, 1, "Pasapalabra Conocimiento del medio 5º" },
                    { 18, 28, 1, "Pasapalabra Conocimiento del medio 6º" },
                    { 19, 4, 1, "Pasapalabra Educación Artística 1º" },
                    { 20, 9, 1, "Pasapalabra Educación Artística 2º" },
                    { 21, 14, 1, "Pasapalabra Educación Artística 3º" },
                    { 22, 19, 1, "Pasapalabra Educación Artística 4º" },
                    { 23, 24, 1, "Pasapalabra Educación Artística 5º" },
                    { 24, 29, 1, "Pasapalabra Educación Artística 6º" },
                    { 25, 5, 1, "Pasapalabra Ingles 1º" },
                    { 26, 10, 1, "Pasapalabra Ingles 2º" },
                    { 27, 15, 1, "Pasapalabra Ingles 3º" },
                    { 28, 20, 1, "Pasapalabra Ingles 4º" },
                    { 29, 25, 1, "Pasapalabra Ingles 5º" },
                    { 30, 30, 1, "Pasapalabra Ingles 6º" }
                });

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CursoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CursoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CursoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CursoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CursoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CursoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CursoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CursoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CursoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CursoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CursoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CursoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CursoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CursoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CursoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CursoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CursoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CursoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CursoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CursoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CursoId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CursoId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CursoId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CursoId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CursoId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CursoId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 27,
                column: "CursoId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 28,
                column: "CursoId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 29,
                column: "CursoId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 30,
                column: "CursoId",
                value: 6);

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_CursoId",
                table: "Asignaturas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_IdAsignatura",
                table: "AsignaturaJuegos",
                column: "IdAsignatura");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_IdTipoJuego",
                table: "AsignaturaJuegos",
                column: "IdTipoJuego");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignaturaJuegos_Asignaturas_IdAsignatura",
                table: "AsignaturaJuegos",
                column: "IdAsignatura",
                principalTable: "Asignaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignaturaJuegos_TipoJuegos_IdTipoJuego",
                table: "AsignaturaJuegos",
                column: "IdTipoJuego",
                principalTable: "TipoJuegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Cursos_CursoId",
                table: "Asignaturas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_AsignaturaJuegos_IdAsignaturaJuego",
                table: "Juegos",
                column: "IdAsignaturaJuego",
                principalTable: "AsignaturaJuegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
