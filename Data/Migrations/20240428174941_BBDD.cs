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
                    PasapalabraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreguntaPasapalabras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreguntaPasapalabras_Pasapalabras_PasapalabraId",
                        column: x => x.PasapalabraId,
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
                table: "Juegos",
                columns: new[] { "Id", "Codigo", "IdAsignaturaJuego", "TemaJuego" },
                values: new object[] { 2, "XXXXXX", 1, "Otra Cosa" });

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[] { 1, 1, "Nombres de autores pasapalabra" });

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[] { 2, 2, "Nombres de otras cosas pasapalabra" });

            migrationBuilder.InsertData(
                table: "resultados",
                columns: new[] { "Id", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[] { 1, 1, 1, 0.0 });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1, "A", 1, "Nombre de autor que empieza por A", "Aaron" },
                    { 2, "B", 2, "Fruta que empieza por B", "Banana" },
                    { 3, "C", 1, "Animal que empieza por C", "Canguro" },
                    { 4, "D", 1, "Capital europea que empieza por D", "Dublín" },
                    { 5, "E", 1, "Elemento químico que empieza por E", "Estroncio" },
                    { 6, "F", 1, "País asiático que empieza por F", "Filipinas" },
                    { 7, "G", 1, "Deporte que empieza por G", "Golf" },
                    { 8, "H", 1, "Instrumento musical que empieza por H", "Harmónica" },
                    { 9, "I", 1, "Planeta que empieza por I", "Júpiter" },
                    { 10, "J", 1, "Actor famoso que empieza por J", "Johnny Depp" },
                    { 11, "K", 1, "Planta que empieza por K", "Kiwi" },
                    { 12, "L", 1, "Color que empieza por L", "Lavanda" },
                    { 13, "M", 1, "Cantante famoso que empieza por M", "Michael Jackson" },
                    { 14, "N", 1, "Río que empieza por N", "Nilo" },
                    { 15, "O", 1, "Película famosa que empieza por O", "El Origen" },
                    { 16, "P", 1, "Instrumento de percusión que empieza por P", "Pandereta" },
                    { 17, "Q", 1, "Animal exótico que empieza por Q", "Quokka" },
                    { 18, "R", 1, "País africano que empieza por R", "Ruanda" },
                    { 19, "S", 1, "Planta aromática que empieza por S", "Salvia" },
                    { 20, "T", 1, "Elemento químico que empieza por T", "Tungsteno" },
                    { 21, "U", 1, "País europeo que empieza por U", "Ucrania" },
                    { 22, "V", 1, "Fruta que empieza por V", "Vainilla" },
                    { 23, "W", 1, "Animal marino que empieza por W", "Ballena" },
                    { 24, "X", 1, "Instrumento musical que empieza por X", "Xilófono" },
                    { 25, "Y", 1, "Ciudad asiática que empieza por Y", "Yakarta" },
                    { 26, "Z", 1, "Fruta tropical que empieza por Z", "Zarzamora" },
                    { 27, "A", 2, "País sudamericano que empieza por A", "Argentina" },
                    { 28, "B", 2, "Elemento químico que empieza por B", "Boro" },
                    { 29, "C", 2, "Capital europea que empieza por C", "Copenhague" },
                    { 30, "D", 2, "Actor de cine que empieza por D", "Denzel Washington" },
                    { 31, "E", 2, "Animal salvaje que empieza por E", "Elefante" },
                    { 32, "F", 2, "Deporte de invierno que empieza por F", "Fútbol" },
                    { 33, "G", 2, "Ciudad europea que empieza por G", "Ginebra" },
                    { 34, "H", 2, "Instrumento de viento que empieza por H", "Hornillo" },
                    { 35, "I", 2, "Planeta que empieza por I", "Iapetus" },
                    { 36, "J", 2, "Cantante famoso que empieza por J", "Justin Bieber" },
                    { 37, "K", 2, "Fruta tropical que empieza por K", "Kumquat" },
                    { 38, "L", 2, "Animal marino que empieza por L", "Langosta" },
                    { 39, "M", 2, "País africano que empieza por M", "Mozambique" },
                    { 40, "N", 2, "Comida típica mexicana que empieza por N", "Nopal" },
                    { 41, "O", 2, "Actor famoso que empieza por O", "Orlando Bloom" },
                    { 42, "P", 2, "Ciudad europea que empieza por P", "París" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 43, "Q", 2, "Animal doméstico que empieza por Q", "Quagga" },
                    { 44, "R", 2, "Elemento químico que empieza por R", "Radio" },
                    { 45, "S", 2, "Cantante famosa que empieza por S", "Selena Gomez" },
                    { 46, "T", 2, "Planta medicinal que empieza por T", "Tilo" },
                    { 47, "U", 2, "País asiático que empieza por U", "Uzbekistán" },
                    { 48, "V", 2, "Animal salvaje que empieza por V", "Víbora" },
                    { 49, "W", 2, "Actor famoso que empieza por W", "Will Smith" },
                    { 50, "X", 2, "Animal exótico que empieza por X", "Xoloitzcuintli" },
                    { 51, "Y", 2, "Río que empieza por Y", "Yukón" },
                    { 52, "Z", 2, "Fruta tropical que empieza por Z", "Zapote" }
                });

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
                name: "IX_PreguntaPasapalabras_PasapalabraId",
                table: "PreguntaPasapalabras",
                column: "PasapalabraId");

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
