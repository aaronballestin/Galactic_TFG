using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avatars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Premium = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CodigoJuego = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCurso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoJuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJuegos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Avatars_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAsignatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsignaturaJuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuegoAsignatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAsignatura = table.Column<int>(type: "int", nullable: false),
                    IdTipoJuego = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignaturaJuegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignaturaJuegos_Asignaturas_IdAsignatura",
                        column: x => x.IdAsignatura,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignaturaJuegos_TipoJuegos_IdTipoJuego",
                        column: x => x.IdTipoJuego,
                        principalTable: "TipoJuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemaJuego = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAsignaturaJuego = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Juegos_AsignaturaJuegos_IdAsignaturaJuego",
                        column: x => x.IdAsignaturaJuego,
                        principalTable: "AsignaturaJuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pasapalabras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdJuego = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasapalabras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pasapalabras_Juegos_IdJuego",
                        column: x => x.IdJuego,
                        principalTable: "Juegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resultados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdJuego = table.Column<int>(type: "int", nullable: false),
                    Resultado = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_resultados_Juegos_IdJuego",
                        column: x => x.IdJuego,
                        principalTable: "Juegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resultados_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreguntaPasapalabras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Letra = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IdPasapalabra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreguntaPasapalabras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreguntaPasapalabras_Pasapalabras_IdPasapalabra",
                        column: x => x.IdPasapalabra,
                        principalTable: "Pasapalabras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Avatars",
                columns: new[] { "Id", "CodigoJuego", "Premium", "RutaFoto" },
                values: new object[] { 1, "XXXXXX", "N", "" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "NombreCurso" },
                values: new object[,]
                {
                    { 1, "1º Primaria" },
                    { 2, "2º Primaria" },
                    { 3, "3º Primaria" },
                    { 4, "4º Primaria" },
                    { 5, "5º Primaria" },
                    { 6, "6º Primaria" }
                });

            migrationBuilder.InsertData(
                table: "TipoJuegos",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 1, "Pasapalabra" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "Id", "CursoId", "NombreAsignatura" },
                values: new object[,]
                {
                    { 1, 1, "Lengua" },
                    { 2, 1, "Matematicas" },
                    { 3, 1, "Conocimiento del medio" },
                    { 4, 1, "Educación Artística" },
                    { 5, 1, "Ingles" },
                    { 6, 2, "Lengua" },
                    { 7, 2, "Matematicas" },
                    { 8, 2, "Conocimiento del medio" },
                    { 9, 2, "Educación Artística" },
                    { 10, 2, "Ingles" },
                    { 11, 3, "Lengua" },
                    { 12, 3, "Matematicas" },
                    { 13, 3, "Conocimiento del medio" },
                    { 14, 3, "Educación Artística" },
                    { 15, 3, "Ingles" },
                    { 16, 4, "Lengua" },
                    { 17, 4, "Matematicas" },
                    { 18, 4, "Conocimiento del medio" },
                    { 19, 4, "Educación Artística" },
                    { 20, 4, "Ingles" },
                    { 21, 5, "Lengua" },
                    { 22, 5, "Matematicas" },
                    { 23, 5, "Conocimiento del medio" },
                    { 24, 5, "Educación Artística" },
                    { 25, 5, "Ingles" },
                    { 26, 6, "Lengua" },
                    { 27, 6, "Matematicas" },
                    { 28, 6, "Conocimiento del medio" },
                    { 29, 6, "Educación Artística" },
                    { 30, 6, "Ingles" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AvatarId", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 1, "aaron@svalero.com", "Aaron", "1234" },
                    { 2, 1, "antonio@svalero.com", "Antonio", "1234" }
                });

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

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Codigo", "IdAsignaturaJuego", "TemaJuego" },
                values: new object[] { 1, "XXXXXX", 1, "Autores" });

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[] { 1, 1, "Nombres de autores pasapalabra" });

            migrationBuilder.InsertData(
                table: "resultados",
                columns: new[] { "Id", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[] { 1, 1, 1, 0.0 });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "IdPasapalabra", "Letra", "Pregunta", "Respuesta" },
                values: new object[] { 1, 1, "A", "Nombre de autor que empieza por A", "Aaron" });

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_IdAsignatura",
                table: "AsignaturaJuegos",
                column: "IdAsignatura");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_IdTipoJuego",
                table: "AsignaturaJuegos",
                column: "IdTipoJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_CursoId",
                table: "Asignaturas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdAsignaturaJuego",
                table: "Juegos",
                column: "IdAsignaturaJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Pasapalabras_IdJuego",
                table: "Pasapalabras",
                column: "IdJuego",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreguntaPasapalabras_IdPasapalabra",
                table: "PreguntaPasapalabras",
                column: "IdPasapalabra");

            migrationBuilder.CreateIndex(
                name: "IX_resultados_IdJuego",
                table: "resultados",
                column: "IdJuego");

            migrationBuilder.CreateIndex(
                name: "IX_resultados_IdUsuario",
                table: "resultados",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AvatarId",
                table: "Usuarios",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreguntaPasapalabras");

            migrationBuilder.DropTable(
                name: "resultados");

            migrationBuilder.DropTable(
                name: "Pasapalabras");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Avatars");

            migrationBuilder.DropTable(
                name: "AsignaturaJuegos");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "TipoJuegos");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
