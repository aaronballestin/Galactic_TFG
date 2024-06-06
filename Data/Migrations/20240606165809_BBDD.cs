using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAsignatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                });

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
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaseId = table.Column<int>(type: "int", nullable: false),
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
                name: "Juegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemaJuego = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAsignatura = table.Column<int>(type: "int", nullable: false),
                    IdCurso = table.Column<int>(type: "int", nullable: false),
                    IdTipoJuego = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Juegos_Asignaturas_IdAsignatura",
                        column: x => x.IdAsignatura,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Juegos_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Juegos_TipoJuegos_IdTipoJuego",
                        column: x => x.IdTipoJuego,
                        principalTable: "TipoJuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ahorcados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdJuego = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ahorcados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ahorcados_Juegos_IdJuego",
                        column: x => x.IdJuego,
                        principalTable: "Juegos",
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
                name: "Resultados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdJuego = table.Column<int>(type: "int", nullable: false),
                    Resultado = table.Column<double>(type: "float", nullable: false),
                    Completado = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Acertadas = table.Column<int>(type: "int", nullable: false),
                    Falladas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resultados_Juegos_IdJuego",
                        column: x => x.IdJuego,
                        principalTable: "Juegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resultados_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreguntaAhorcados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AhorcadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreguntaAhorcados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreguntaAhorcados_Ahorcados_AhorcadoId",
                        column: x => x.AhorcadoId,
                        principalTable: "Ahorcados",
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
                table: "Asignaturas",
                columns: new[] { "Id", "NombreAsignatura" },
                values: new object[,]
                {
                    { 1, "Lengua" },
                    { 2, "Matemáticas" },
                    { 3, "Conocimiento del medio" },
                    { 4, "Educación Artística" },
                    { 5, "Inglés" }
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
                values: new object[,]
                {
                    { 1, "Pasapalabra" },
                    { 2, "Ahorcado" }
                });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Codigo", "IdAsignatura", "IdCurso", "IdTipoJuego", "TemaJuego" },
                values: new object[,]
                {
                    { 1, "XXXXXX", 3, 1, 1, "Geografía Basica" },
                    { 2, "XXXXXX", 3, 1, 1, "Cultura General - 1" },
                    { 3, "XXXXXX", 3, 1, 1, "Cultura General - 2" },
                    { 4, "XXXXXX", 5, 1, 1, "Inglés Basic - 1" },
                    { 5, "XXXXXX", 5, 1, 1, "Inglés Animals - 1" },
                    { 6, "XXXXXX", 2, 1, 1, "Matemáticas - General" },
                    { 7, "XXXXXX", 1, 1, 1, "Lengua - 1" },
                    { 8, "XXXXXX", 1, 1, 1, "Lengua - 2" },
                    { 9, "XXXXXX", 4, 1, 1, "Plastica" },
                    { 10, "XXXXXX", 4, 1, 1, "Música" },
                    { 11, "XXXXXX", 3, 2, 1, "Geografía Basica" },
                    { 12, "XXXXXX", 3, 2, 1, "Cultura General - 1" },
                    { 13, "XXXXXX", 3, 2, 1, "Cultura General - 2" },
                    { 14, "XXXXXX", 5, 2, 1, "Inglés Basic - 1" },
                    { 15, "XXXXXX", 5, 2, 1, "Inglés Animals - 1" },
                    { 16, "XXXXXX", 2, 2, 1, "Matemáticas - General" },
                    { 17, "XXXXXX", 1, 2, 1, "Lengua - 1" },
                    { 21, "XXXXXX", 3, 3, 1, "Geografía Basica" },
                    { 22, "XXXXXX", 3, 3, 1, "Cultura General - 1" },
                    { 23, "XXXXXX", 3, 3, 1, "Cultura General - 2" },
                    { 24, "XXXXXX", 5, 3, 1, "Inglés Basic - 1" },
                    { 25, "XXXXXX", 5, 3, 1, "Inglés Animals - 1" },
                    { 26, "XXXXXX", 2, 3, 1, "Matemáticas - General" },
                    { 27, "XXXXXX", 1, 3, 1, "Lengua - 1" },
                    { 31, "XXXXXX", 3, 4, 1, "Geografía Basica" },
                    { 32, "XXXXXX", 3, 4, 1, "Cultura General - 1" },
                    { 33, "XXXXXX", 3, 4, 1, "Cultura General - 2" },
                    { 34, "XXXXXX", 5, 4, 1, "Inglés Basic - 1" },
                    { 35, "XXXXXX", 5, 4, 1, "Inglés Animals - 1" },
                    { 36, "XXXXXX", 2, 4, 1, "Matemáticas - General" },
                    { 37, "XXXXXX", 1, 4, 1, "Lengua - 1" },
                    { 41, "XXXXXX", 3, 5, 1, "Geografía Basica" },
                    { 42, "XXXXXX", 3, 5, 1, "Cultura General - 1" },
                    { 43, "XXXXXX", 3, 5, 1, "Cultura General - 2" },
                    { 44, "XXXXXX", 5, 5, 1, "Inglés Basic - 1" },
                    { 45, "XXXXXX", 5, 5, 1, "Inglés Animals - 1" },
                    { 46, "XXXXXX", 2, 5, 1, "Matemáticas - General" },
                    { 47, "XXXXXX", 1, 5, 1, "Lengua - 1" },
                    { 51, "XXXXXX", 3, 6, 1, "Geografía Basica" },
                    { 52, "XXXXXX", 3, 6, 1, "Cultura General - 1" },
                    { 53, "XXXXXX", 3, 6, 1, "Cultura General - 2" },
                    { 54, "XXXXXX", 5, 6, 1, "Ingles Basic - 1" }
                });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Codigo", "IdAsignatura", "IdCurso", "IdTipoJuego", "TemaJuego" },
                values: new object[,]
                {
                    { 55, "XXXXXX", 5, 6, 1, "Ingles Animals - 1" },
                    { 56, "XXXXXX", 2, 6, 1, "Matemáticas - General" },
                    { 57, "XXXXXX", 1, 6, 1, "Lengua - 1" },
                    { 61, "XXXXXX", 1, 1, 2, "Lengua - 1" },
                    { 62, "XXXXXX", 2, 1, 2, "Matemáticas - 2" },
                    { 63, "XXXXXX", 3, 1, 2, "Geografía - 3" },
                    { 64, "XXXXXX", 4, 1, 2, "Música - 4" },
                    { 65, "XXXXXX", 5, 1, 2, "Varios - 5" },
                    { 66, "XXXXXX", 1, 2, 2, "Lengua - 1" },
                    { 67, "XXXXXX", 2, 2, 2, "Matemáticas - 1" },
                    { 68, "XXXXXX", 3, 2, 2, "Geografía - 1" },
                    { 69, "XXXXXX", 4, 2, 2, "Música - 1" },
                    { 70, "XXXXXX", 5, 2, 2, "Inglés - 1" },
                    { 71, "XXXXXX", 1, 3, 2, "Lengua - 1" },
                    { 72, "XXXXXX", 2, 3, 2, "Matemáticas - 1" },
                    { 73, "XXXXXX", 3, 3, 2, "Geografía - 1" },
                    { 74, "XXXXXX", 4, 3, 2, "Música - 1" },
                    { 75, "XXXXXX", 5, 3, 2, "Inglés - 1" },
                    { 76, "XXXXXX", 1, 4, 2, "Lengua - 1" },
                    { 77, "XXXXXX", 2, 4, 2, "Matemáticas - 1" },
                    { 78, "XXXXXX", 3, 4, 2, "Geografía - 1" },
                    { 79, "XXXXXX", 4, 4, 2, "Música - 1" },
                    { 80, "XXXXXX", 5, 4, 2, "Inglés - 1" },
                    { 81, "XXXXXX", 1, 5, 2, "Lengua - 1" },
                    { 82, "XXXXXX", 2, 5, 2, "Matemáticas - 1" },
                    { 83, "XXXXXX", 3, 5, 2, "Geografía - 1" },
                    { 84, "XXXXXX", 4, 5, 2, "Música - 1" },
                    { 85, "XXXXXX", 5, 5, 2, "Inglés - 1" },
                    { 86, "XXXXXX", 1, 6, 2, "Lengua - 1" },
                    { 87, "XXXXXX", 2, 6, 2, "Matemáticas - 1" },
                    { 88, "XXXXXX", 3, 6, 2, "Geografía - 1" },
                    { 89, "XXXXXX", 4, 6, 2, "Música - 1" },
                    { 90, "XXXXXX", 5, 6, 2, "Inglés - 1" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AvatarId", "ClaseId", "Email", "Name", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, 1, 0, "aaron@svalero.com", "Aaron", "1234", "Admin" },
                    { 2, 1, 1, "antonio@svalero.com", "Antonio", "1234", "Profesor" },
                    { 3, 1, 1, "profesor1@svalero.com", "Profesor1", "1234", "Profesor" },
                    { 4, 1, 1, "alumno4@svalero.com", "alumno4", "1234", "Alumno" },
                    { 5, 1, 1, "alumno5@svalero.com", "alumno5", "1234", "Alumno" },
                    { 6, 1, 1, "alumno6@svalero.com", "alumno6", "1234", "Alumno" },
                    { 7, 1, 1, "alumno7@svalero.com", "alumno7", "1234", "Alumno" },
                    { 8, 1, 1, "alumno8@svalero.com", "alumno8", "1234", "Alumno" },
                    { 9, 1, 1, "alumno9@svalero.com", "alumno9", "1234", "Alumno" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AvatarId", "ClaseId", "Email", "Name", "Password", "Rol" },
                values: new object[,]
                {
                    { 10, 1, 1, "alumno10@svalero.com", "alumno10", "1234", "Alumno" },
                    { 11, 1, 2, "alumno11@svalero.com", "alumno11", "1234", "Alumno" },
                    { 12, 1, 2, "alumno12@svalero.com", "alumno12", "1234", "Alumno" },
                    { 13, 1, 2, "alumno13@svalero.com", "alumno13", "1234", "Alumno" },
                    { 14, 1, 2, "alumno14@svalero.com", "alumno14", "1234", "Alumno" },
                    { 15, 1, 2, "alumno15@svalero.com", "alumno15", "1234", "Alumno" },
                    { 16, 1, 2, "alumno16@svalero.com", "alumno16", "1234", "Alumno" },
                    { 17, 1, 2, "alumno17@svalero.com", "alumno17", "1234", "Alumno" },
                    { 18, 1, 2, "alumno18@svalero.com", "alumno18", "1234", "Alumno" },
                    { 19, 1, 2, "alumno19@svalero.com", "alumno19", "1234", "Alumno" },
                    { 20, 1, 2, "alumno20@svalero.com", "alumno20", "1234", "Alumno" },
                    { 102, 1, 2, "profesor2@svalero.com", "Profesor2", "1234", "Profesor" }
                });

            migrationBuilder.InsertData(
                table: "Ahorcados",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[,]
                {
                    { 61, 61, "Ahorcado de Lengua - 1" },
                    { 62, 62, "Ahorcado de Matemáticas - 2" },
                    { 63, 63, "Ahorcado de Geografía - 3" },
                    { 64, 64, "Ahorcado de Música - 4" },
                    { 65, 65, "Ahorcado de Varios - 5" },
                    { 66, 66, "Ahorcado de Lengua - 1" },
                    { 67, 67, "Ahorcado de Matemáticas - 1" },
                    { 68, 68, "Ahorcado de Geografía - 1" },
                    { 69, 69, "Ahorcado de Música - 1" },
                    { 70, 70, "Ahorcado de Inglés - 1" },
                    { 71, 71, "Ahorcado de Lengua - 1" },
                    { 72, 72, "Ahorcado de Matemáticas - 1" },
                    { 73, 73, "Ahorcado de Geografía - 1" },
                    { 74, 74, "Ahorcado de Música - 1" },
                    { 75, 75, "Ahorcado de Inglés - 1" },
                    { 76, 76, "Ahorcado de Lengua - 1" },
                    { 77, 77, "Ahorcado de Matemáticas - 1" },
                    { 78, 78, "Ahorcado de Geografía - 1" },
                    { 79, 79, "Ahorcado de Música - 1" },
                    { 80, 80, "Ahorcado de Inglés - 1" },
                    { 81, 81, "Ahorcado de Lengua - 1" },
                    { 82, 82, "Ahorcado de Matemáticas - 1" },
                    { 83, 83, "Ahorcado de Geografía - 1" },
                    { 84, 84, "Ahorcado de Música - 1" },
                    { 85, 85, "Ahorcado de Inglés - 1" },
                    { 86, 86, "Ahorcado de Lengua - 1" },
                    { 87, 87, "Ahorcado de Matemáticas - 1" },
                    { 88, 88, "Ahorcado de Geografía - 1" },
                    { 89, 89, "Ahorcado de Música - 1" },
                    { 90, 90, "Ahorcado de Inglés - 1" }
                });

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Geografía" },
                    { 2, 2, "Conocimientos del medio" },
                    { 3, 3, "Conocimientos del medio" },
                    { 4, 4, "Inglés Basic" },
                    { 5, 5, "Ingles Animals" },
                    { 6, 6, "Matemáticas - 1" },
                    { 7, 7, "Lengua - 1" },
                    { 8, 8, "Lengua - 2" },
                    { 9, 9, "Plastica" },
                    { 10, 10, "Musica" },
                    { 11, 11, "Geografía" },
                    { 12, 12, "Nombres de otras cosas pasapalabra" }
                });

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[,]
                {
                    { 13, 13, "Nombres de otras cosas pasapalabra" },
                    { 14, 14, "Nombres de otras cosas pasapalabra" },
                    { 15, 15, "Nombres de otras cosas pasapalabra" },
                    { 16, 16, "Nombres de otras cosas pasapalabra" },
                    { 17, 17, "Nombres de otras cosas pasapalabra" },
                    { 21, 21, "Geografía" },
                    { 22, 22, "Nombres de otras cosas pasapalabra" },
                    { 23, 23, "Nombres de otras cosas pasapalabra" },
                    { 24, 24, "Nombres de otras cosas pasapalabra" },
                    { 25, 25, "Nombres de otras cosas pasapalabra" },
                    { 26, 26, "Nombres de otras cosas pasapalabra" },
                    { 27, 27, "Nombres de otras cosas pasapalabra" },
                    { 31, 31, "Geografía" },
                    { 32, 32, "Nombres de otras cosas pasapalabra" },
                    { 33, 33, "Nombres de otras cosas pasapalabra" },
                    { 34, 34, "Nombres de otras cosas pasapalabra" },
                    { 35, 35, "Nombres de otras cosas pasapalabra" },
                    { 36, 36, "Nombres de otras cosas pasapalabra" },
                    { 37, 37, "Nombres de otras cosas pasapalabra" },
                    { 41, 41, "Geografía" },
                    { 42, 42, "Nombres de otras cosas pasapalabra" },
                    { 43, 43, "Nombres de otras cosas pasapalabra" },
                    { 44, 44, "Nombres de otras cosas pasapalabra" },
                    { 45, 45, "Nombres de otras cosas pasapalabra" },
                    { 46, 46, "Nombres de otras cosas pasapalabra" },
                    { 47, 47, "Nombres de otras cosas pasapalabra" },
                    { 51, 51, "Geografía" },
                    { 52, 52, "Nombres de otras cosas pasapalabra" },
                    { 53, 53, "Nombres de otras cosas pasapalabra" },
                    { 54, 54, "Nombres de otras cosas pasapalabra" },
                    { 55, 55, "Nombres de otras cosas pasapalabra" },
                    { 56, 56, "Nombres de otras cosas pasapalabra" },
                    { 57, 57, "Nombres de otras cosas pasapalabra" }
                });

            migrationBuilder.InsertData(
                table: "Resultados",
                columns: new[] { "Id", "Acertadas", "Completado", "Falladas", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[,]
                {
                    { 1, 27, "Y", 0, 1, 3, 100.0 },
                    { 2, 27, "Y", 0, 1, 3, 100.0 },
                    { 3, 27, "Y", 0, 1, 1, 100.0 },
                    { 4, 27, "Y", 0, 1, 1, 100.0 },
                    { 5, 27, "Y", 0, 1, 11, 100.0 },
                    { 6, 27, "Y", 0, 1, 11, 100.0 },
                    { 7, 27, "Y", 0, 1, 11, 100.0 },
                    { 8, 27, "Y", 0, 1, 11, 100.0 },
                    { 9, 27, "Y", 0, 1, 11, 100.0 }
                });

            migrationBuilder.InsertData(
                table: "Resultados",
                columns: new[] { "Id", "Acertadas", "Completado", "Falladas", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[,]
                {
                    { 10, 27, "Y", 0, 1, 13, 100.0 },
                    { 11, 27, "Y", 0, 1, 4, 100.0 },
                    { 12, 27, "Y", 0, 1, 5, 100.0 },
                    { 13, 27, "Y", 0, 1, 6, 100.0 },
                    { 14, 27, "Y", 0, 1, 7, 100.0 },
                    { 15, 27, "Y", 0, 1, 8, 100.0 },
                    { 16, 27, "Y", 0, 1, 9, 100.0 },
                    { 17, 27, "Y", 0, 1, 10, 100.0 },
                    { 18, 27, "Y", 0, 1, 17, 100.0 }
                });

            migrationBuilder.InsertData(
                table: "PreguntaAhorcados",
                columns: new[] { "Id", "AhorcadoId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1, 61, "¿Cuál es el género literario de 'Don Quijote de la Mancha'?", "Novela" },
                    { 2, 62, "¿Cómo se llama el resultado de multiplicar dos números en Matemáticas?", "Producto" },
                    { 3, 63, "¿Cuál es el río más largo del mundo?", "Amazonas" },
                    { 4, 64, "¿Quién compuso la ópera 'La flauta mágica'?", "Mozart" },
                    { 5, 65, "¿Cuál es el idioma más hablado en el mundo?", "Mandarín" },
                    { 6, 66, "¿Cuál es el tema del poema 'Las Rimas' de Gustavo Adolfo Bécquer?", "Amor" },
                    { 7, 67, "¿Cómo se llama el conjunto de puntos que están a la misma distancia de un punto fijo en Matemáticas?", "Circunferencia" },
                    { 8, 68, "¿Cuál es la capital de Australia?", "Canberra" },
                    { 9, 69, "¿Qué instrumento musical utiliza un arco y cuatro cuerdas?", "Violín" },
                    { 10, 70, "¿Cómo se llama el idioma oficial de Brasil?", "Portugués" },
                    { 11, 71, "¿Qué obra escribió García Márquez que ganó el Nobel?", "Cien" },
                    { 12, 72, "¿Cómo se llama la figura geométrica con tres lados?", "Triángulo" },
                    { 13, 73, "¿Cuál es el país más grande del mundo por superficie?", "Rusia" },
                    { 14, 74, "¿Quién compuso la Novena Sinfonía?", "Beethoven" },
                    { 15, 75, "¿Cuál es la ciudad capital de Inglaterra?", "Londres" },
                    { 16, 76, "¿Qué autor escribió 'La casa de Bernarda Alba'?", "Lorca" },
                    { 17, 77, "¿Cómo se llama el polígono con seis lados?", "Hexágono" },
                    { 18, 78, "¿Qué continente está completamente en el hemisferio sur?", "Australia" },
                    { 19, 79, "¿Qué instrumento musical tiene teclas blancas y negras?", "Piano" },
                    { 20, 80, "¿Cuál es la lengua oficial de Alemania?", "Alemán" },
                    { 21, 81, "¿Quién escribió 'Cien Años de Soledad'?", "García" },
                    { 22, 82, "¿Qué figura geométrica tiene todos sus lados iguales?", "Cuadrado" },
                    { 23, 83, "¿Cuál es el océano más grande del mundo?", "Pacífico" },
                    { 24, 84, "¿Quién es conocido como el 'Rey del Pop'?", "Jackson" },
                    { 25, 85, "¿Qué idioma se habla en Italia?", "Italiano" },
                    { 26, 86, "¿Quién escribió 'Don Quijote de la Mancha'?", "Cervantes" },
                    { 27, 87, "¿Qué es una línea que une dos puntos en una circunferencia?", "Cuerda" },
                    { 28, 88, "¿Cuál es el país más pequeño del mundo?", "Vaticano" },
                    { 29, 89, "¿Qué compositor es conocido por 'Las cuatro estaciones'?", "Vivaldi" },
                    { 30, 90, "¿Cuál es el idioma oficial de Francia?", "Francés" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1, "A", 1, "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", "Asia" },
                    { 2, "B", 1, "Empieza por B: Capital de Alemania, famosa por su Muro", "Berlín" },
                    { 3, "C", 1, "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", "Chile" },
                    { 4, "D", 1, "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", "Dinamarca" },
                    { 5, "E", 1, "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", "Egipto" },
                    { 6, "F", 1, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" },
                    { 7, "G", 1, "Empieza por G: País de América Central cuyo nombre rima con 'mala'", "Guatemala" },
                    { 8, "H", 1, "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", "Honduras" },
                    { 9, "I", 1, "Empieza por I: País europeo conocido por su forma de bota", "Italia" },
                    { 10, "J", 1, "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", "Japón" },
                    { 11, "K", 1, "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", "Kazajistán" },
                    { 12, "L", 1, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 13, "M", 1, "Empieza por M: País del norte de África famoso por sus mercados en Marrakech", "Marruecos" },
                    { 14, "N", 1, "Empieza por N: País escandinavo de Europa conocido por sus fiordos", "Noruega" },
                    { 15, "O", 1, "Empieza por O: País de Asia famoso por su desierto y su incienso", "Omán" },
                    { 16, "P", 1, "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", "Portugal" },
                    { 17, "Q", 1, "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", "Qatar" },
                    { 18, "R", 1, "Empieza por R: País más grande del mundo, situado en Europa y Asia", "Rusia" },
                    { 19, "S", 1, "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", "Suecia" },
                    { 20, "T", 1, "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", "Tailandia" },
                    { 21, "U", 1, "Empieza por U: País de Europa del Este cuya capital es Kiev", "Ucrania" },
                    { 22, "V", 1, "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", "Vietnam" },
                    { 23, "W", 1, "Empieza por W: Territorio de Oceanía compuesto por tres islas principales", "Wallis y Futuna" },
                    { 24, "X", 1, "Empieza por X: Ciudad china famosa por sus guerreros de terracota", "Xi'an" },
                    { 25, "Y", 1, "Empieza por Y: País de la península arábiga cuyo capital es Saná", "Yemen" },
                    { 26, "Z", 1, "Empieza por Z: País del sur de África cuya capital es Lusaka", "Zambia" },
                    { 27, "A", 2, "Empieza por A: Nombre de un animal volador conocido por su aguda visión", "Águila" },
                    { 28, "B", 2, "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", "Banana" },
                    { 29, "C", 2, "Empieza por C: Nombre de un color primario, mezcla de azul y verde", "Cian" },
                    { 30, "D", 2, "Empieza por D: Nombre de un dinosaurio herbívoro con un cuello muy largo", "Diplodocus" },
                    { 31, "E", 2, "Empieza por E: Nombre del continente donde se encuentra España", "Europa" },
                    { 32, "F", 2, "Empieza por F: Nombre de un instrumento musical de viento muy utilizado en la música andina", "Flauta" },
                    { 33, "G", 2, "Empieza por G: Nombre de un deporte que se juega en un campo con 18 hoyos", "Golf" },
                    { 34, "H", 2, "Empieza por H: Nombre del tercer planeta del sistema solar en algunas lenguas", "Helio" },
                    { 35, "I", 2, "Empieza por I: Nombre de un país europeo famoso por su comida y su forma de bota", "Italia" },
                    { 36, "J", 2, "Empieza por J: Nombre del séptimo mes del año", "Julio" },
                    { 37, "K", 2, "Empieza por K: Nombre de un arte marcial japonés", "Karate" },
                    { 38, "L", 2, "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", "Laúd" },
                    { 39, "M", 2, "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", "Mediterráneo" },
                    { 40, "N", 2, "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", "Nieve" },
                    { 41, "O", 2, "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", "Orca" },
                    { 42, "P", 2, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" },
                    { 43, "Q", 2, "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", "Quino" },
                    { 44, "R", 2, "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", "Rectángulo" },
                    { 45, "S", 2, "Empieza por S: Nombre de una ciudad española famosa por su catedral y su feria de abril", "Sevilla" },
                    { 46, "T", 2, "Empieza por T: Nombre de un país euroasiático que tiene a Estambul como una de sus ciudades", "Turquía" },
                    { 47, "U", 2, "Empieza por U: Nombre del séptimo planeta del sistema solar", "Urano" },
                    { 48, "V", 2, "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", "Violín" },
                    { 49, "W", 2, "Empieza por W: Nombre de un famoso parque de atracciones en Florida", "Walt Disney World" },
                    { 50, "X", 2, "Empieza por X: Nombre de un instrumento de percusión con placas de madera", "Xilófono" },
                    { 51, "Y", 2, "Empieza por Y: Nombre de un río muy largo en China", "Yangtsé" },
                    { 52, "Z", 2, "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", "Zebra" },
                    { 53, "A", 3, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 54, "B", 3, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 55, "C", 3, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 56, "D", 3, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 57, "E", 3, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 58, "F", 3, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 59, "G", 3, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 60, "H", 3, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
                    { 61, "I", 3, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 62, "J", 3, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 63, "K", 3, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 64, "L", 3, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 65, "M", 3, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 66, "N", 3, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
                    { 67, "O", 3, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 68, "P", 3, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 69, "Q", 3, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 70, "R", 3, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 71, "S", 3, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 72, "T", 3, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 73, "U", 3, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 74, "V", 3, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 75, "W", 3, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 76, "X", 3, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
                    { 77, "Y", 3, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 78, "Z", 3, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 79, "A", 4, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 80, "B", 4, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 81, "C", 4, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 82, "D", 4, "Empieza por D: The opposite of 'night'", "Day" },
                    { 83, "E", 4, "Empieza por E: The planet we live on", "Earth" },
                    { 84, "F", 4, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 85, "G", 4, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 86, "H", 4, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 87, "I", 4, "Empieza por I: Frozen water", "Ice" },
                    { 88, "J", 4, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 89, "K", 4, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 90, "L", 4, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 91, "M", 4, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 92, "N", 4, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 93, "O", 4, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 94, "P", 4, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 95, "Q", 4, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 96, "R", 4, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 97, "S", 4, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 98, "T", 4, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 99, "U", 4, "Empieza por U: The color of a clear sky", "Blue" },
                    { 100, "V", 4, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 101, "W", 4, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 102, "X", 4, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 103, "Y", 4, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 104, "Z", 4, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 105, "A", 5, "Empieza por A: A type of large reptile that lives in water and on land", "Alligator" },
                    { 106, "B", 5, "Empieza por B: A flying insect that produces honey", "Bee" },
                    { 107, "C", 5, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 108, "D", 5, "Empieza por D: A small, round fruit that is often red or black", "Date" },
                    { 109, "E", 5, "Empieza por E: A flying insect known for its painful sting", "Wasp" },
                    { 110, "F", 5, "Empieza por F: An animal similar a cat", "Fox" },
                    { 111, "G", 5, "Empieza por G: A small, round fruit that is often red or black", "Grape" },
                    { 112, "H", 5, "Empieza por H: A tropical fruit with a hard shell and sweet, white flesh", "Honeydew" },
                    { 113, "I", 5, "Empieza por I: A large bird known for its long neck", "Ibis" },
                    { 114, "J", 5, "Empieza por J: A type of large bird that can't fly", "Jabiru" },
                    { 115, "K", 5, "Empieza por K: A marsupial native to Australia known for jumping", "Kangaroo" },
                    { 116, "L", 5, "Empieza por L: A South American mammal known for its wool", "Llama" },
                    { 117, "M", 5, "Empieza por M: A small carnivorous mammal known for its agility and speed", "Mongoose" },
                    { 118, "N", 5, "Empieza por N: A small marsupial native to Australia", "Numbat" },
                    { 119, "O", 5, "Empieza por O: A wild cat native to the Americas", "Ocelot" },
                    { 121, "Q", 5, "Empieza por Q: A small bird often hunted for sport", "Quail" },
                    { 123, "S", 5, "Empieza por S: A slow-moving mammal known for hanging from trees", "Sloth" },
                    { 124, "T", 5, "Empieza por T: A large bird often associated with Thanksgiving", "Turkey" },
                    { 125, "U", 5, "Empieza por U: A wild sheep native to the mountains of Asia", "Urial" },
                    { 126, "V", 5, "Empieza por V: A large bird known for scavenging carrion", "Vulture" },
                    { 127, "W", 5, "Empieza por W: A small marsupial native to Australia", "Wallaby" },
                    { 128, "X", 5, "Empieza por X: A small mammal native to Africa", "Xerus" },
                    { 129, "Y", 5, "Empieza por Y: A large mammal native to the Himalayas", "Yak" },
                    { 130, "Z", 5, "Empieza por Z: A large striped mammal native to Africa", "Zebra" },
                    { 131, "A", 6, "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", "Aritmética" },
                    { 132, "B", 6, "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", "Binomio" },
                    { 133, "C", 6, "Empieza por C: ¿Cuál es la disciplina matemática que estudia el cambio y la acumulación mediante límites, derivadas e integrales?", "Cálculo" },
                    { 134, "D", 6, "Empieza por D: ¿Qué concepto matemático representa la tasa de cambio instantáneo de una función?", "Derivada" },
                    { 135, "E", 6, "Empieza por E: ¿Cómo se llama una igualdad matemática que contiene una o más incógnitas?", "Ecuación" },
                    { 136, "F", 6, "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", "Función" },
                    { 137, "G", 6, "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños, y las propiedades del espacio?", "Geometría" },
                    { 138, "H", 6, "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", "Hipotenusa" },
                    { 139, "I", 6, "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", "Integral" },
                    { 140, "J", 6, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 141, "K", 6, "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", "Kardinalidad" },
                    { 142, "L", 6, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" },
                    { 143, "M", 6, "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", "Matriz" },
                    { 144, "N", 6, "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", "Número" },
                    { 145, "O", 6, "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", "Operación" },
                    { 146, "P", 6, "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", "Polinomio" },
                    { 147, "Q", 6, "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", "Quociente" },
                    { 148, "R", 6, "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", "Raíz" },
                    { 150, "S", 6, "Empieza por S: ¿Qué operación matemática se utiliza para combinar dos o más cantidades?", "Suma" },
                    { 151, "T", 6, "Empieza por T: ¿Qué función trigonométrica representa la razón entre el lado opuesto y el lado adyacente de un ángulo en un triángulo rectángulo?", "Tangente" },
                    { 152, "U", 6, "Empieza por U: ¿Qué término se utiliza para denotar una cantidad específica utilizada como estándar de medida?", "Unidad" },
                    { 153, "V", 6, "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", "Vector" },
                    { 154, "W", 6, "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", "Wronskiano" },
                    { 155, "X", 6, "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", "X-intercepto" },
                    { 156, "Y", 6, "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", "Y-intercepto" },
                    { 157, "Z", 6, "Empieza por Z: En ingles, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" },
                    { 158, "A", 7, "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", "Artículo" },
                    { 159, "B", 7, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 160, "C", 7, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 161, "D", 7, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 162, "E", 7, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 163, "F", 7, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 164, "G", 7, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 165, "H", 7, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" },
                    { 166, "I", 7, "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", "Interjección" },
                    { 167, "J", 7, "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", "Juego" },
                    { 168, "K", 7, "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", "Kiosco" },
                    { 169, "L", 7, "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", "Letra" },
                    { 170, "M", 7, "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", "Morfema" },
                    { 171, "N", 7, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" },
                    { 172, "O", 7, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 173, "P", 7, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" },
                    { 174, "Q", 7, "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", "Querido" },
                    { 175, "R", 7, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" },
                    { 176, "S", 7, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 177, "T", 7, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 178, "U", 7, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 179, "V", 7, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 180, "W", 7, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 181, "X", 7, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" },
                    { 183, "Y", 7, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 184, "Z", 7, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 185, "A", 8, "¿Qué parte de la oración describe o califica al sustantivo?", "Adjetivo" },
                    { 186, "B", 8, "¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 187, "C", 8, "¿Qué tipo de palabra une dos oraciones o partes de una oración?", "Conjunción" },
                    { 188, "D", 8, "¿Cómo se llama la secuencia de dos vocales que se pronuncian en una sola emisión de voz?", "Diptongo" },
                    { 189, "E", 8, "¿Cómo se llama el conjunto de palabras que expresan una idea completa?", "Enunciado" },
                    { 190, "F", 8, "¿Cómo se le llama a la unidad mínima de sonido en un idioma?", "Fonema" },
                    { 191, "G", 8, "¿Qué rama de la lingüística estudia la estructura de las palabras?", "Gramática" },
                    { 192, "H", 8, "¿Cómo se llama una palabra que suena igual que otra pero se escribe diferente y tiene distinto significado?", "Homófono" },
                    { 193, "I", 8, "¿Cómo se llama una palabra que expresa emoción o sentimiento y no tiene relación gramatical con otras palabras de la oración?", "Interjección" },
                    { 194, "J", 8, "¿Cómo se le llama al lenguaje especializado de un grupo profesional o social?", "Jerga" },
                    { 195, "K", 8, "¿Qué arte marcial tiene su origen en Okinawa, Japón?", "Kárate" },
                    { 196, "L", 8, "¿Cómo se le llama a cada una de las grafías del alfabeto?", "Letra" },
                    { 197, "M", 8, "¿Cómo se llama la unidad mínima de significado en la palabra?", "Morfema" },
                    { 198, "N", 8, "¿Cómo se llama la palabra que designa a personas, animales, cosas o ideas?", "Nombre" },
                    { 199, "O", 8, "¿Cómo se llama una frase que expresa una idea completa con sentido propio?", "Oración" },
                    { 200, "P", 8, "¿Cómo se llama la palabra que sustituye al nombre?", "Pronombre" },
                    { 201, "Q", 8, "¿Qué error gramatical se produce al usar de forma incorrecta la palabra 'que'?", "Queísmo" },
                    { 202, "R", 8, "¿Cómo se le llama a la repetición de sonidos al final de dos o más versos?", "Rima" },
                    { 203, "S", 8, "¿Quién o qué realiza la acción en una oración?", "Sujeto" },
                    { 204, "T", 8, "¿Cómo se llama la forma en que se conjugan los verbos para indicar el momento en que se realiza la acción?", "Tiempo verbal" },
                    { 205, "U", 8, "¿Cómo se llama la manera correcta de emplear el lenguaje según las normas gramaticales?", "Uso" },
                    { 206, "V", 8, "¿Cómo se llama la forma verbal en la que el sujeto recibe la acción del verbo?", "Voz pasiva" },
                    { 207, "W", 8, "¿Qué baile originario de África Central se popularizó en los años 60?", "Watusi" },
                    { 208, "X", 8, "¿Qué técnica de impresión se realiza sobre madera?", "Xilografía" },
                    { 209, "Y", 8, "¿Cómo se le llama a la unión de dos o más ideas o palabras sin relación gramatical?", "Yuxtaposición" },
                    { 210, "Z", 8, "¿Cómo se le llama al uso de un mismo término para dos sentidos diferentes en un enunciado?", "Zeugma" },
                    { 211, "A", 9, "¿Qué tipo de pintura se diluye en agua y se aplica con pincel?", "Acuarela" },
                    { 212, "B", 9, "¿Qué material se utiliza para modelar figuras y vasijas?", "Barro" },
                    { 213, "C", 9, "¿Con qué herramienta se pueden colorear dibujos?", "Crayón" },
                    { 214, "D", 9, "¿Qué actividad implica plasmar ideas en papel?", "Dibujo" },
                    { 215, "E", 9, "¿Qué arte consiste en esculpir figuras en materiales como arcilla o piedra?", "Escultura" },
                    { 216, "F", 9, "¿Cómo se le llama a una representación visual de una forma?", "Figura" },
                    { 217, "G", 9, "¿Qué material se usa para borrar trazos en papel?", "Goma" },
                    { 218, "H", 9, "¿Sobre qué superficie se dibuja o pinta?", "Hoja" },
                    { 219, "I", 9, "¿Cómo se llama una representación visual de algo?", "Imagen" },
                    { 220, "J", 9, "¿Qué se hace con materiales para divertirse y aprender?", "Juego" },
                    { 221, "K", 9, "¿Qué conjunto de herramientas se utiliza para crear arte?", "Kit" },
                    { 222, "L", 9, "¿Qué objeto se usa para colorear o dibujar?", "Lápiz" },
                    { 223, "M", 9, "¿Qué masa se utiliza para modelar figuras?", "Masa" },
                    { 224, "N", 9, "¿Qué se estudia en plástica relacionado con la vida natural?", "Naturaleza" },
                    { 225, "O", 9, "¿Qué tipo de pintura se hace con óleo?", "Óleo" },
                    { 226, "P", 9, "¿Sobre qué se pueden realizar dibujos o manualidades?", "Papel" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 227, "Q", 9, "¿Qué utensilio se utiliza para calentar y endurecer cerámica?", "Quemador" },
                    { 228, "R", 9, "¿Qué objeto se utiliza para extender pintura de forma uniforme?", "Rodillo" },
                    { 229, "S", 9, "¿Qué se utiliza para estampar diseños en papel?", "Sello" },
                    { 230, "T", 9, "¿Qué tipo de pintura se utiliza en manualidades y en la escuela?", "Tempera" },
                    { 231, "U", 9, "¿Qué se hace con los materiales de arte y manualidades?", "Uso" },
                    { 232, "V", 9, "¿En qué se bebe agua o se mezcla pintura?", "Vaso" },
                    { 233, "W", 9, "¿Qué tipo de cinta adhesiva se utiliza para decorar?", "Washi" },
                    { 234, "X", 9, "¿Qué técnica de impresión se realiza sobre madera?", "Xilografía" },
                    { 235, "Y", 9, "¿Qué material se usa para modelar figuras y realizar moldes?", "Yeso" },
                    { 236, "Z", 9, "¿Qué patrón se forma con líneas que se juntan y separan de forma diagonal?", "Zigzag" },
                    { 237, "A", 10, "¿Qué conjunto de sonidos simultáneos forman la base de la armonía?", "Acorde" },
                    { 238, "B", 10, "¿Qué instrumento de percusión se compone de tambores y platillos?", "Batería" },
                    { 239, "C", 10, "¿Cómo se llama una composición musical con letra?", "Canción" },
                    { 240, "D", 10, "¿Cuál es la primera nota de la escala musical?", "Do" },
                    { 241, "E", 10, "¿Qué serie de notas ordenadas de forma ascendente y descendente forman una escala?", "Escala" },
                    { 242, "F", 10, "¿Qué instrumento de viento se toca soplando por un tubo?", "Flauta" },
                    { 243, "G", 10, "¿Qué instrumento de cuerda se toca frotando las cuerdas con un arco?", "Guitarra" },
                    { 244, "H", 10, "¿Qué tipo de sonido se produce al hacer vibrar una cuerda o columna de aire?", "Harmónico" },
                    { 245, "I", 10, "¿Cómo se llama el objeto utilizado para producir música?", "Instrumento" },
                    { 246, "J", 10, "¿Qué estilo musical se caracteriza por su improvisación y ritmo syncopado?", "Jazz" },
                    { 247, "K", 10, "¿Cómo se llama un tambor grande utilizado en orquestas y bandas militares?", "Kettledrum" },
                    { 248, "L", 10, "¿Qué parte de una canción contiene las palabras que se cantan?", "Letra" },
                    { 249, "M", 10, "¿Qué se llama a una secuencia de sonidos sucesivos que forman una unidad melódica?", "Melodía" },
                    { 250, "N", 10, "¿Qué se utiliza para representar gráficamente el sonido en una partitura?", "Nota" },
                    { 251, "O", 10, "¿Qué instrumento produce sonido mediante el paso de aire a través de tubos?", "Órgano" },
                    { 252, "P", 10, "¿Qué instrumento de teclado se toca con los dedos?", "Piano" },
                    { 253, "Q", 10, "¿Cómo se llama un grupo de cuatro músicos?", "Quarteto" },
                    { 254, "R", 10, "¿Qué elemento marca la sucesión de sonidos en una pieza musical?", "Ritmo" },
                    { 255, "S", 10, "¿Qué sistema de enseñanza musical utiliza símbolos para representar los sonidos?", "Solfeo" },
                    { 256, "T", 10, "¿Qué instrumento de percusión se golpea para producir sonidos?", "Tambor" },
                    { 257, "U", 10, "¿Qué instrumento tiene cuatro cuerdas y se toca con los dedos o con un plectro?", "Ukelele" },
                    { 258, "V", 10, "¿Qué instrumento de cuerda se toca frotando las cuerdas con un arco?", "Violín" },
                    { 259, "W", 10, "¿Qué instrumento se utiliza para hacer sonidos agudos soplando?", "Whistle" },
                    { 260, "X", 10, "¿Qué instrumento de percusión tiene láminas que se golpean para producir sonido?", "Xilófono" },
                    { 261, "Y", 10, "¿Qué parte de la baqueta se utiliza para golpear un tambor?", "Yema" },
                    { 262, "Z", 10, "¿Qué tipo de patrón se forma con líneas que se juntan y separan de forma zigzagueante?", "Zigzag" },
                    { 263, "A", 11, "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", "Asia" },
                    { 264, "B", 11, "Empieza por B: Capital de Alemania, famosa por su Muro", "Berlín" },
                    { 265, "C", 11, "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", "Chile" },
                    { 266, "D", 11, "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", "Dinamarca" },
                    { 267, "E", 11, "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", "Egipto" },
                    { 268, "F", 11, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 269, "G", 11, "Empieza por G: País de América Central cuyo nombre rima con 'mala'", "Guatemala" },
                    { 270, "H", 11, "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", "Honduras" },
                    { 271, "I", 11, "Empieza por I: País europeo conocido por su forma de bota", "Italia" },
                    { 272, "J", 11, "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", "Japón" },
                    { 273, "K", 11, "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", "Kazajistán" },
                    { 274, "L", 11, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" },
                    { 275, "M", 11, "Empieza por M: País del norte de África famoso por sus mercados en Marrakech", "Marruecos" },
                    { 276, "N", 11, "Empieza por N: País escandinavo de Europa conocido por sus fiordos", "Noruega" },
                    { 277, "O", 11, "Empieza por O: País de Asia famoso por su desierto y su incienso", "Omán" },
                    { 278, "P", 11, "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", "Portugal" },
                    { 279, "Q", 11, "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", "Qatar" },
                    { 280, "R", 11, "Empieza por R: País más grande del mundo, situado en Europa y Asia", "Rusia" },
                    { 281, "S", 11, "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", "Suecia" },
                    { 282, "T", 11, "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", "Tailandia" },
                    { 283, "U", 11, "Empieza por U: País de Europa del Este cuya capital es Kiev", "Ucrania" },
                    { 284, "V", 11, "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", "Vietnam" },
                    { 285, "W", 11, "Empieza por W: Territorio de Oceanía compuesto por tres islas principales", "Wallis y Futuna" },
                    { 286, "X", 11, "Empieza por X: Ciudad china famosa por sus guerreros de terracota", "Xi'an" },
                    { 287, "Y", 11, "Empieza por Y: País de la península arábiga cuyo capital es Saná", "Yemen" },
                    { 288, "Z", 11, "Empieza por Z: País del sur de África cuya capital es Lusaka", "Zambia" },
                    { 289, "A", 21, "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", "Asia" },
                    { 290, "B", 21, "Empieza por B: Capital de Alemania, famosa por su Muro", "Berlín" },
                    { 291, "C", 21, "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", "Chile" },
                    { 292, "D", 21, "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", "Dinamarca" },
                    { 293, "E", 21, "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", "Egipto" },
                    { 294, "F", 21, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" },
                    { 295, "G", 21, "Empieza por G: País de América Central cuyo nombre rima con 'mala'", "Guatemala" },
                    { 296, "H", 21, "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", "Honduras" },
                    { 297, "I", 21, "Empieza por I: País europeo conocido por su forma de bota", "Italia" },
                    { 298, "J", 21, "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", "Japón" },
                    { 299, "K", 21, "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", "Kazajistán" },
                    { 300, "L", 21, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" },
                    { 301, "M", 21, "Empieza por M: País del norte de África famoso por sus mercados en Marrakech", "Marruecos" },
                    { 302, "N", 21, "Empieza por N: País escandinavo de Europa conocido por sus fiordos", "Noruega" },
                    { 303, "O", 21, "Empieza por O: País de Asia famoso por su desierto y su incienso", "Omán" },
                    { 304, "P", 21, "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", "Portugal" },
                    { 305, "Q", 21, "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", "Qatar" },
                    { 306, "R", 21, "Empieza por R: País más grande del mundo, situado en Europa y Asia", "Rusia" },
                    { 307, "S", 21, "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", "Suecia" },
                    { 308, "T", 21, "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", "Tailandia" },
                    { 309, "U", 21, "Empieza por U: País de Europa del Este cuya capital es Kiev", "Ucrania" },
                    { 310, "V", 21, "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", "Vietnam" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 311, "W", 21, "Empieza por W: Territorio de Oceanía compuesto por tres islas principales", "Wallis y Futuna" },
                    { 312, "X", 21, "Empieza por X: Ciudad china famosa por sus guerreros de terracota", "Xi'an" },
                    { 313, "Y", 21, "Empieza por Y: País de la península arábiga cuyo capital es Saná", "Yemen" },
                    { 314, "Z", 21, "Empieza por Z: País del sur de África cuya capital es Lusaka", "Zambia" },
                    { 315, "A", 31, "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", "Asia" },
                    { 316, "B", 31, "Empieza por B: Capital de Alemania, famosa por su Muro", "Berlín" },
                    { 317, "C", 31, "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", "Chile" },
                    { 318, "D", 31, "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", "Dinamarca" },
                    { 319, "E", 31, "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", "Egipto" },
                    { 320, "F", 31, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" },
                    { 321, "G", 31, "Empieza por G: País de América Central cuyo nombre rima con 'mala'", "Guatemala" },
                    { 322, "H", 31, "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", "Honduras" },
                    { 323, "I", 31, "Empieza por I: País europeo conocido por su forma de bota", "Italia" },
                    { 324, "J", 31, "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", "Japón" },
                    { 325, "K", 31, "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", "Kazajistán" },
                    { 326, "L", 31, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" },
                    { 327, "M", 31, "Empieza por M: País del norte de África famoso por sus mercados en Marrakech", "Marruecos" },
                    { 328, "N", 31, "Empieza por N: País escandinavo de Europa conocido por sus fiordos", "Noruega" },
                    { 329, "O", 31, "Empieza por O: País de Asia famoso por su desierto y su incienso", "Omán" },
                    { 330, "P", 31, "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", "Portugal" },
                    { 331, "Q", 31, "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", "Qatar" },
                    { 332, "R", 31, "Empieza por R: País más grande del mundo, situado en Europa y Asia", "Rusia" },
                    { 333, "S", 31, "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", "Suecia" },
                    { 334, "T", 31, "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", "Tailandia" },
                    { 335, "U", 31, "Empieza por U: País de Europa del Este cuya capital es Kiev", "Ucrania" },
                    { 336, "V", 31, "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", "Vietnam" },
                    { 337, "W", 31, "Empieza por W: Territorio de Oceanía compuesto por tres islas principales", "Wallis y Futuna" },
                    { 338, "X", 31, "Empieza por X: Ciudad china famosa por sus guerreros de terracota", "Xi'an" },
                    { 339, "Y", 31, "Empieza por Y: País de la península arábiga cuyo capital es Saná", "Yemen" },
                    { 340, "Z", 31, "Empieza por Z: País del sur de África cuya capital es Lusaka", "Zambia" },
                    { 341, "A", 41, "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", "Asia" },
                    { 342, "B", 41, "Empieza por B: Capital de Alemania, famosa por su Muro", "Berlín" },
                    { 343, "C", 41, "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", "Chile" },
                    { 344, "D", 41, "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", "Dinamarca" },
                    { 345, "E", 41, "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", "Egipto" },
                    { 346, "F", 41, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" },
                    { 347, "G", 41, "Empieza por G: País de América Central cuyo nombre rima con 'mala'", "Guatemala" },
                    { 348, "H", 41, "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", "Honduras" },
                    { 349, "I", 41, "Empieza por I: País europeo conocido por su forma de bota", "Italia" },
                    { 350, "J", 41, "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", "Japón" },
                    { 351, "K", 41, "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", "Kazajistán" },
                    { 352, "L", 41, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 353, "M", 41, "Empieza por M: País del norte de África famoso por sus mercados en Marrakech", "Marruecos" },
                    { 354, "N", 41, "Empieza por N: País escandinavo de Europa conocido por sus fiordos", "Noruega" },
                    { 355, "O", 41, "Empieza por O: País de Asia famoso por su desierto y su incienso", "Omán" },
                    { 356, "P", 41, "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", "Portugal" },
                    { 357, "Q", 41, "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", "Qatar" },
                    { 358, "R", 41, "Empieza por R: País más grande del mundo, situado en Europa y Asia", "Rusia" },
                    { 359, "S", 41, "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", "Suecia" },
                    { 360, "T", 41, "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", "Tailandia" },
                    { 361, "U", 41, "Empieza por U: País de Europa del Este cuya capital es Kiev", "Ucrania" },
                    { 362, "V", 41, "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", "Vietnam" },
                    { 363, "W", 41, "Empieza por W: Territorio de Oceanía compuesto por tres islas principales", "Wallis y Futuna" },
                    { 364, "X", 41, "Empieza por X: Ciudad china famosa por sus guerreros de terracota", "Xi'an" },
                    { 365, "Y", 41, "Empieza por Y: País de la península arábiga cuyo capital es Saná", "Yemen" },
                    { 366, "Z", 41, "Empieza por Z: País del sur de África cuya capital es Lusaka", "Zambia" },
                    { 367, "A", 12, "Empieza por A: Nombre de un animal volador conocido por su aguda visión", "Águila" },
                    { 368, "B", 12, "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", "Banana" },
                    { 369, "C", 12, "Empieza por C: Nombre de un color primario, mezcla de azul y verde", "Cian" },
                    { 370, "D", 12, "Empieza por D: Nombre de un dinosaurio herbívoro con un cuello muy largo", "Diplodocus" },
                    { 371, "E", 12, "Empieza por E: Nombre del continente donde se encuentra España", "Europa" },
                    { 372, "F", 12, "Empieza por F: Nombre de un instrumento musical de viento muy utilizado en la música andina", "Flauta" },
                    { 373, "G", 12, "Empieza por G: Nombre de un deporte que se juega en un campo con 18 hoyos", "Golf" },
                    { 374, "H", 12, "Empieza por H: Nombre del tercer planeta del sistema solar en algunas lenguas", "Helio" },
                    { 375, "I", 12, "Empieza por I: Nombre de un país europeo famoso por su comida y su forma de bota", "Italia" },
                    { 376, "J", 12, "Empieza por J: Nombre del séptimo mes del año", "Julio" },
                    { 377, "K", 12, "Empieza por K: Nombre de un arte marcial japonés", "Karate" },
                    { 378, "L", 12, "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", "Laúd" },
                    { 379, "M", 12, "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", "Mediterráneo" },
                    { 380, "N", 12, "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", "Nieve" },
                    { 381, "O", 12, "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", "Orca" },
                    { 382, "P", 12, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" },
                    { 383, "Q", 12, "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", "Quino" },
                    { 384, "R", 12, "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", "Rectángulo" },
                    { 385, "S", 12, "Empieza por S: Nombre de una ciudad española famosa por su catedral y su feria de abril", "Sevilla" },
                    { 386, "T", 12, "Empieza por T: Nombre de un país euroasiático que tiene a Estambul como una de sus ciudades", "Turquía" },
                    { 387, "U", 12, "Empieza por U: Nombre del séptimo planeta del sistema solar", "Urano" },
                    { 388, "V", 12, "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", "Violín" },
                    { 389, "W", 12, "Empieza por W: Nombre de un famoso parque de atracciones en Florida", "Walt Disney World" },
                    { 390, "X", 12, "Empieza por X: Nombre de un instrumento de percusión con placas de madera", "Xilófono" },
                    { 391, "Y", 12, "Empieza por Y: Nombre de un río muy largo en China", "Yangtsé" },
                    { 392, "Z", 12, "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", "Zebra" },
                    { 393, "A", 22, "Empieza por A: Nombre de un animal volador conocido por su aguda visión", "Águila" },
                    { 394, "B", 22, "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", "Banana" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 395, "C", 22, "Empieza por C: Nombre de un color primario, mezcla de azul y verde", "Cian" },
                    { 396, "D", 22, "Empieza por D: Nombre de un dinosaurio herbívoro con un cuello muy largo", "Diplodocus" },
                    { 397, "E", 22, "Empieza por E: Nombre del continente donde se encuentra España", "Europa" },
                    { 398, "F", 22, "Empieza por F: Nombre de un instrumento musical de viento muy utilizado en la música andina", "Flauta" },
                    { 399, "G", 22, "Empieza por G: Nombre de un deporte que se juega en un campo con 18 hoyos", "Golf" },
                    { 400, "H", 22, "Empieza por H: Nombre del tercer planeta del sistema solar en algunas lenguas", "Helio" },
                    { 401, "I", 22, "Empieza por I: Nombre de un país europeo famoso por su comida y su forma de bota", "Italia" },
                    { 402, "J", 22, "Empieza por J: Nombre del séptimo mes del año", "Julio" },
                    { 403, "K", 22, "Empieza por K: Nombre de un arte marcial japonés", "Karate" },
                    { 404, "L", 22, "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", "Laúd" },
                    { 405, "M", 22, "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", "Mediterráneo" },
                    { 406, "N", 22, "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", "Nieve" },
                    { 407, "O", 22, "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", "Orca" },
                    { 408, "P", 22, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" },
                    { 409, "Q", 22, "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", "Quino" },
                    { 410, "R", 22, "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", "Rectángulo" },
                    { 411, "S", 22, "Empieza por S: Nombre de una ciudad española famosa por su catedral y su feria de abril", "Sevilla" },
                    { 412, "T", 22, "Empieza por T: Nombre de un país euroasiático que tiene a Estambul como una de sus ciudades", "Turquía" },
                    { 413, "U", 22, "Empieza por U: Nombre del séptimo planeta del sistema solar", "Urano" },
                    { 414, "V", 22, "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", "Violín" },
                    { 415, "W", 22, "Empieza por W: Nombre de un famoso parque de atracciones en Florida", "Walt Disney World" },
                    { 416, "X", 22, "Empieza por X: Nombre de un instrumento de percusión con placas de madera", "Xilófono" },
                    { 417, "Y", 22, "Empieza por Y: Nombre de un río muy largo en China", "Yangtsé" },
                    { 418, "Z", 22, "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", "Zebra" },
                    { 419, "A", 32, "Empieza por A: Nombre de un animal volador conocido por su aguda visión", "Águila" },
                    { 420, "B", 32, "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", "Banana" },
                    { 421, "C", 32, "Empieza por C: Nombre de un color primario, mezcla de azul y verde", "Cian" },
                    { 422, "D", 32, "Empieza por D: Nombre de un dinosaurio herbívoro con un cuello muy largo", "Diplodocus" },
                    { 423, "E", 32, "Empieza por E: Nombre del continente donde se encuentra España", "Europa" },
                    { 424, "F", 32, "Empieza por F: Nombre de un instrumento musical de viento muy utilizado en la música andina", "Flauta" },
                    { 425, "G", 32, "Empieza por G: Nombre de un deporte que se juega en un campo con 18 hoyos", "Golf" },
                    { 426, "H", 32, "Empieza por H: Nombre del tercer planeta del sistema solar en algunas lenguas", "Helio" },
                    { 427, "I", 32, "Empieza por I: Nombre de un país europeo famoso por su comida y su forma de bota", "Italia" },
                    { 428, "J", 32, "Empieza por J: Nombre del séptimo mes del año", "Julio" },
                    { 429, "K", 32, "Empieza por K: Nombre de un arte marcial japonés", "Karate" },
                    { 430, "L", 32, "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", "Laúd" },
                    { 431, "M", 32, "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", "Mediterráneo" },
                    { 432, "N", 32, "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", "Nieve" },
                    { 433, "O", 32, "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", "Orca" },
                    { 434, "P", 32, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" },
                    { 435, "Q", 32, "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", "Quino" },
                    { 436, "R", 32, "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", "Rectángulo" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 437, "S", 32, "Empieza por S: Nombre de una ciudad española famosa por su catedral y su feria de abril", "Sevilla" },
                    { 438, "T", 32, "Empieza por T: Nombre de un país euroasiático que tiene a Estambul como una de sus ciudades", "Turquía" },
                    { 439, "U", 32, "Empieza por U: Nombre del séptimo planeta del sistema solar", "Urano" },
                    { 440, "V", 32, "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", "Violín" },
                    { 441, "W", 32, "Empieza por W: Nombre de un famoso parque de atracciones en Florida", "Walt Disney World" },
                    { 442, "X", 32, "Empieza por X: Nombre de un instrumento de percusión con placas de madera", "Xilófono" },
                    { 443, "Y", 32, "Empieza por Y: Nombre de un río muy largo en China", "Yangtsé" },
                    { 444, "Z", 32, "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", "Zebra" },
                    { 445, "A", 42, "Empieza por A: Nombre de un animal volador conocido por su aguda visión", "Águila" },
                    { 446, "B", 42, "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", "Banana" },
                    { 447, "C", 42, "Empieza por C: Nombre de un color primario, mezcla de azul y verde", "Cian" },
                    { 448, "D", 42, "Empieza por D: Nombre de un dinosaurio herbívoro con un cuello muy largo", "Diplodocus" },
                    { 449, "E", 42, "Empieza por E: Nombre del continente donde se encuentra España", "Europa" },
                    { 450, "F", 42, "Empieza por F: Nombre de un instrumento musical de viento muy utilizado en la música andina", "Flauta" },
                    { 451, "G", 42, "Empieza por G: Nombre de un deporte que se juega en un campo con 18 hoyos", "Golf" },
                    { 452, "H", 42, "Empieza por H: Nombre del tercer planeta del sistema solar en algunas lenguas", "Helio" },
                    { 453, "I", 42, "Empieza por I: Nombre de un país europeo famoso por su comida y su forma de bota", "Italia" },
                    { 454, "J", 42, "Empieza por J: Nombre del séptimo mes del año", "Julio" },
                    { 455, "K", 42, "Empieza por K: Nombre de un arte marcial japonés", "Karate" },
                    { 456, "L", 42, "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", "Laúd" },
                    { 457, "M", 42, "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", "Mediterráneo" },
                    { 458, "N", 42, "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", "Nieve" },
                    { 459, "O", 42, "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", "Orca" },
                    { 460, "P", 42, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" },
                    { 461, "Q", 42, "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", "Quino" },
                    { 462, "R", 42, "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", "Rectángulo" },
                    { 463, "S", 42, "Empieza por S: Nombre de una ciudad española famosa por su catedral y su feria de abril", "Sevilla" },
                    { 464, "T", 42, "Empieza por T: Nombre de un país euroasiático que tiene a Estambul como una de sus ciudades", "Turquía" },
                    { 465, "U", 42, "Empieza por U: Nombre del séptimo planeta del sistema solar", "Urano" },
                    { 466, "V", 42, "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", "Violín" },
                    { 467, "W", 42, "Empieza por W: Nombre de un famoso parque de atracciones en Florida", "Walt Disney World" },
                    { 468, "X", 42, "Empieza por X: Nombre de un instrumento de percusión con placas de madera", "Xilófono" },
                    { 469, "Y", 42, "Empieza por Y: Nombre de un río muy largo en China", "Yangtsé" },
                    { 470, "Z", 42, "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", "Zebra" },
                    { 471, "A", 13, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 472, "B", 13, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 473, "C", 13, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 474, "D", 13, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 475, "E", 13, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 476, "F", 13, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 477, "G", 13, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 478, "H", 13, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 479, "I", 13, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 480, "J", 13, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 481, "K", 13, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 482, "L", 13, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 483, "M", 13, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 484, "N", 13, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
                    { 485, "O", 13, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 486, "P", 13, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 487, "Q", 13, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 488, "R", 13, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 489, "S", 13, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 490, "T", 13, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 491, "U", 13, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 492, "V", 13, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 493, "W", 13, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 494, "X", 13, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
                    { 495, "Y", 13, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 496, "Z", 13, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 497, "A", 13, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 498, "B", 13, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 499, "C", 13, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 500, "D", 13, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 501, "E", 13, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 502, "F", 13, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 503, "G", 13, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 504, "H", 13, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
                    { 505, "I", 13, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 506, "J", 13, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 507, "K", 13, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 508, "L", 13, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 509, "M", 13, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 510, "N", 13, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
                    { 511, "O", 13, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 512, "P", 13, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 513, "Q", 13, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 514, "R", 13, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 515, "S", 13, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 516, "T", 13, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 517, "U", 13, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 518, "V", 13, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 519, "W", 13, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 520, "X", 13, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 521, "Y", 13, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 522, "Z", 13, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 523, "A", 23, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 524, "B", 23, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 525, "C", 23, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 526, "D", 23, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 527, "E", 23, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 528, "F", 23, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 529, "G", 23, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 530, "H", 23, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
                    { 531, "I", 23, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 532, "J", 23, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 533, "K", 23, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 534, "L", 23, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 535, "M", 23, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 536, "N", 23, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
                    { 537, "O", 23, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 538, "P", 23, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 539, "Q", 23, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 540, "R", 23, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 541, "S", 23, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 542, "T", 23, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 543, "U", 23, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 544, "V", 23, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 545, "W", 23, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 546, "X", 23, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
                    { 547, "Y", 23, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 548, "Z", 23, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 549, "A", 33, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 550, "B", 33, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 551, "C", 33, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 552, "D", 33, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 553, "E", 33, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 554, "F", 33, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 555, "G", 33, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 556, "H", 33, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
                    { 557, "I", 33, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 558, "J", 33, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 559, "K", 33, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 560, "L", 33, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 561, "M", 33, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 562, "N", 33, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 563, "O", 33, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 564, "P", 33, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 565, "Q", 33, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 566, "R", 33, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 567, "S", 33, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 568, "T", 33, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 569, "U", 33, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 570, "V", 33, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 571, "W", 33, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 572, "X", 33, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
                    { 573, "Y", 33, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 574, "Z", 33, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 575, "A", 43, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 576, "B", 43, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 577, "C", 43, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 578, "D", 43, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 579, "E", 43, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 580, "F", 43, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 581, "G", 43, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 582, "H", 43, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
                    { 583, "I", 43, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 584, "J", 43, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 585, "K", 43, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 586, "L", 43, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 587, "M", 43, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 588, "N", 43, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
                    { 589, "O", 43, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 590, "P", 43, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 591, "Q", 43, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 592, "R", 43, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 593, "S", 43, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 594, "T", 43, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 595, "U", 43, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 596, "V", 43, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 597, "W", 43, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 598, "X", 43, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
                    { 599, "Y", 43, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 600, "Z", 43, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 601, "A", 53, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 602, "B", 53, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 603, "C", 53, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 604, "D", 53, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 605, "E", 53, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 606, "F", 53, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 607, "G", 53, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 608, "H", 53, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
                    { 609, "I", 53, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 610, "J", 53, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 611, "K", 53, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 612, "L", 53, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 613, "M", 53, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 614, "N", 53, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
                    { 615, "O", 53, "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", "Oxígeno" },
                    { 616, "P", 53, "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", "Placa" },
                    { 617, "Q", 53, "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", "Química" },
                    { 618, "R", 53, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" },
                    { 619, "S", 53, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 620, "T", 53, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 621, "U", 53, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 622, "V", 53, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 623, "W", 53, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 624, "X", 53, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
                    { 625, "Y", 53, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 626, "Z", 53, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 627, "A", 14, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 628, "B", 14, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 629, "C", 14, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 630, "D", 14, "Empieza por D: The opposite of 'night'", "Day" },
                    { 631, "E", 14, "Empieza por E: The planet we live on", "Earth" },
                    { 632, "F", 14, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 633, "G", 14, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 634, "H", 14, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 635, "I", 14, "Empieza por I: Frozen water", "Ice" },
                    { 636, "J", 14, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 637, "K", 14, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 638, "L", 14, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 639, "M", 14, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 640, "N", 14, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 641, "O", 14, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 642, "P", 14, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 643, "Q", 14, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 644, "R", 14, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 645, "S", 14, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 646, "T", 14, "Empieza por T: The opposite of 'short'", "Tall" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 647, "U", 14, "Empieza por U: The color of a clear sky", "Blue" },
                    { 648, "V", 14, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 649, "W", 14, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 650, "X", 14, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 651, "Y", 14, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 652, "Z", 14, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 653, "A", 24, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 654, "B", 24, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 655, "C", 24, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 656, "D", 24, "Empieza por D: The opposite of 'night'", "Day" },
                    { 657, "E", 24, "Empieza por E: The planet we live on", "Earth" },
                    { 658, "F", 24, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 659, "G", 24, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 660, "H", 24, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 661, "I", 24, "Empieza por I: Frozen water", "Ice" },
                    { 662, "J", 24, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 663, "K", 24, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 664, "L", 24, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 665, "M", 24, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 666, "N", 24, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 667, "O", 24, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 668, "P", 24, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 669, "Q", 24, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 670, "R", 24, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 671, "S", 24, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 672, "T", 24, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 673, "U", 24, "Empieza por U: The color of a clear sky", "Blue" },
                    { 674, "V", 24, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 675, "W", 24, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 676, "X", 24, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 677, "Y", 24, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 678, "Z", 24, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 679, "A", 34, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 680, "B", 34, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 681, "C", 34, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 682, "D", 34, "Empieza por D: The opposite of 'night'", "Day" },
                    { 683, "E", 34, "Empieza por E: The planet we live on", "Earth" },
                    { 684, "F", 34, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 685, "G", 34, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 686, "H", 34, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 687, "I", 34, "Empieza por I: Frozen water", "Ice" },
                    { 688, "J", 34, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 689, "K", 34, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 690, "L", 34, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 691, "M", 34, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 692, "N", 34, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 693, "O", 34, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 694, "P", 34, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 695, "Q", 34, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 696, "R", 34, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 697, "S", 34, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 698, "T", 34, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 699, "U", 34, "Empieza por U: The color of a clear sky", "Blue" },
                    { 700, "V", 34, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 701, "W", 34, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 702, "X", 34, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 703, "Y", 34, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 704, "Z", 34, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 705, "A", 44, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 706, "B", 44, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 707, "C", 44, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 708, "D", 44, "Empieza por D: The opposite of 'night'", "Day" },
                    { 709, "E", 44, "Empieza por E: The planet we live on", "Earth" },
                    { 710, "F", 44, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 711, "G", 44, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 712, "H", 44, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 713, "I", 44, "Empieza por I: Frozen water", "Ice" },
                    { 714, "J", 44, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 715, "K", 44, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 716, "L", 44, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 717, "M", 44, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 718, "N", 44, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 719, "O", 44, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 720, "P", 44, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 721, "Q", 44, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 722, "R", 44, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 723, "S", 44, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 724, "T", 44, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 725, "U", 44, "Empieza por U: The color of a clear sky", "Blue" },
                    { 726, "V", 44, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 727, "W", 44, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 728, "X", 44, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 729, "Y", 44, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 730, "Z", 44, "Empieza por Z: A wild animal with black and white stripes", "Zebra" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 731, "A", 54, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 732, "B", 54, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 733, "C", 54, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 734, "D", 54, "Empieza por D: The opposite of 'night'", "Day" },
                    { 735, "E", 54, "Empieza por E: The planet we live on", "Earth" },
                    { 736, "F", 54, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 737, "G", 54, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 738, "H", 54, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 739, "I", 54, "Empieza por I: Frozen water", "Ice" },
                    { 740, "J", 54, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 741, "K", 54, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 742, "L", 54, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 743, "M", 54, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 744, "N", 54, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 745, "O", 54, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 746, "P", 54, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 747, "Q", 54, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 748, "R", 54, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 749, "S", 54, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 750, "T", 54, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 751, "U", 54, "Empieza por U: The color of a clear sky", "Blue" },
                    { 752, "V", 54, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 753, "W", 54, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 754, "X", 54, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 755, "Y", 54, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 756, "Z", 54, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 757, "A", 15, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 758, "B", 15, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 759, "C", 15, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 760, "D", 15, "Empieza por D: The opposite of 'night'", "Day" },
                    { 761, "E", 15, "Empieza por E: The planet we live on", "Earth" },
                    { 762, "F", 15, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 763, "G", 15, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 764, "H", 15, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 765, "I", 15, "Empieza por I: Frozen water", "Ice" },
                    { 766, "J", 15, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 767, "K", 15, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 768, "L", 15, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 769, "M", 15, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 770, "N", 15, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 771, "O", 15, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 772, "P", 15, "Empieza por P: A large mammal known for its trunk", "Elephant" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 773, "Q", 15, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 774, "R", 15, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 775, "S", 15, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 776, "T", 15, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 777, "U", 15, "Empieza por U: The color of a clear sky", "Blue" },
                    { 778, "V", 15, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 779, "W", 15, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 780, "X", 15, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 781, "Y", 15, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 782, "Z", 15, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 783, "A", 25, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 784, "B", 25, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 785, "C", 25, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 786, "D", 25, "Empieza por D: The opposite of 'night'", "Day" },
                    { 787, "E", 25, "Empieza por E: The planet we live on", "Earth" },
                    { 788, "F", 25, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 789, "G", 25, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 790, "H", 25, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 791, "I", 25, "Empieza por I: Frozen water", "Ice" },
                    { 792, "J", 25, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 793, "K", 25, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 794, "L", 25, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 795, "M", 25, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 796, "N", 25, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 797, "O", 25, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 798, "P", 25, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 799, "Q", 25, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 800, "R", 25, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 801, "S", 25, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 802, "T", 25, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 803, "U", 25, "Empieza por U: The color of a clear sky", "Blue" },
                    { 804, "V", 25, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 805, "W", 25, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 806, "X", 25, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 807, "Y", 25, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 808, "Z", 25, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 809, "A", 35, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 810, "B", 35, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 811, "C", 35, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 812, "D", 35, "Empieza por D: The opposite of 'night'", "Day" },
                    { 813, "E", 35, "Empieza por E: The planet we live on", "Earth" },
                    { 814, "F", 35, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 815, "G", 35, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 816, "H", 35, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 817, "I", 35, "Empieza por I: Frozen water", "Ice" },
                    { 818, "J", 35, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 819, "K", 35, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 820, "L", 35, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 821, "M", 35, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 822, "N", 35, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 823, "O", 35, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 824, "P", 35, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 825, "Q", 35, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 826, "R", 35, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 827, "S", 35, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 828, "T", 35, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 829, "U", 35, "Empieza por U: The color of a clear sky", "Blue" },
                    { 830, "V", 35, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 831, "W", 35, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 832, "X", 35, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 833, "Y", 35, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 834, "Z", 35, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 835, "A", 45, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 836, "B", 45, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 837, "C", 45, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 838, "D", 45, "Empieza por D: The opposite of 'night'", "Day" },
                    { 839, "E", 45, "Empieza por E: The planet we live on", "Earth" },
                    { 840, "F", 45, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 841, "G", 45, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 842, "H", 45, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 843, "I", 45, "Empieza por I: Frozen water", "Ice" },
                    { 844, "J", 45, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 845, "K", 45, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 846, "L", 45, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 847, "M", 45, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 848, "N", 45, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 849, "O", 45, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 850, "P", 45, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 851, "Q", 45, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 852, "R", 45, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 853, "S", 45, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 854, "T", 45, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 855, "U", 45, "Empieza por U: The color of a clear sky", "Blue" },
                    { 856, "V", 45, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 857, "W", 45, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 858, "X", 45, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 859, "Y", 45, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 860, "Z", 45, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 861, "A", 55, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 862, "B", 55, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 863, "C", 55, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 864, "D", 55, "Empieza por D: The opposite of 'night'", "Day" },
                    { 865, "E", 55, "Empieza por E: The planet we live on", "Earth" },
                    { 866, "F", 55, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 867, "G", 55, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 868, "H", 55, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 869, "I", 55, "Empieza por I: Frozen water", "Ice" },
                    { 870, "J", 55, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
                    { 871, "K", 55, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 872, "L", 55, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 873, "M", 55, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 874, "N", 55, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 875, "O", 55, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 876, "P", 55, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 877, "Q", 55, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 878, "R", 55, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 879, "S", 55, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 880, "T", 55, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 881, "U", 55, "Empieza por U: The color of a clear sky", "Blue" },
                    { 882, "V", 55, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 883, "W", 55, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 884, "X", 55, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 885, "Y", 55, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 886, "Z", 55, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
                    { 887, "A", 16, "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", "Aritmética" },
                    { 888, "B", 16, "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", "Binomio" },
                    { 889, "C", 16, "Empieza por C: ¿Cuál es la disciplina matemática que estudia el cambio y la acumulación mediante límites, derivadas e integrales?", "Cálculo" },
                    { 890, "D", 16, "Empieza por D: ¿Qué concepto matemático representa la tasa de cambio instantáneo de una función?", "Derivada" },
                    { 891, "E", 16, "Empieza por E: ¿Cómo se llama una igualdad matemática que contiene una o más incógnitas?", "Ecuación" },
                    { 892, "F", 16, "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", "Función" },
                    { 893, "G", 16, "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños, y las propiedades del espacio?", "Geometría" },
                    { 894, "H", 16, "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", "Hipotenusa" },
                    { 895, "I", 16, "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", "Integral" },
                    { 896, "J", 16, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" },
                    { 897, "K", 16, "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", "Kardinalidad" },
                    { 898, "L", 16, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 899, "M", 16, "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", "Matriz" },
                    { 900, "N", 16, "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", "Número" },
                    { 901, "O", 16, "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", "Operación" },
                    { 902, "P", 16, "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", "Polinomio" },
                    { 903, "Q", 16, "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", "Quociente" },
                    { 904, "R", 16, "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", "Raíz" },
                    { 905, "S", 16, "Empieza por S: ¿Qué operación matemática se utiliza para combinar dos o más cantidades?", "Suma" },
                    { 906, "T", 16, "Empieza por T: ¿Qué función trigonométrica representa la razón entre el lado opuesto y el lado adyacente de un ángulo en un triángulo rectángulo?", "Tangente" },
                    { 907, "U", 16, "Empieza por U: ¿Qué término se utiliza para denotar una cantidad específica utilizada como estándar de medida?", "Unidad" },
                    { 908, "V", 16, "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", "Vector" },
                    { 909, "W", 16, "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", "Wronskiano" },
                    { 910, "X", 16, "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", "X-intercepto" },
                    { 911, "Y", 16, "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", "Y-intercepto" },
                    { 912, "Z", 16, "Empieza por Z: En ingles, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" },
                    { 913, "A", 26, "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", "Aritmética" },
                    { 914, "B", 26, "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", "Binomio" },
                    { 915, "C", 26, "Empieza por C: ¿Cuál es la disciplina matemática que estudia el cambio y la acumulación mediante límites, derivadas e integrales?", "Cálculo" },
                    { 916, "D", 26, "Empieza por D: ¿Qué concepto matemático representa la tasa de cambio instantáneo de una función?", "Derivada" },
                    { 917, "E", 26, "Empieza por E: ¿Cómo se llama una igualdad matemática que contiene una o más incógnitas?", "Ecuación" },
                    { 918, "F", 26, "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", "Función" },
                    { 919, "G", 26, "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños y las propiedades del espacio?", "Geometría" },
                    { 920, "H", 26, "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", "Hipotenusa" },
                    { 921, "I", 26, "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", "Integral" },
                    { 922, "J", 26, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" },
                    { 923, "K", 26, "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", "Kardinalidad" },
                    { 924, "L", 26, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" },
                    { 925, "M", 26, "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", "Matriz" },
                    { 926, "N", 26, "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", "Número" },
                    { 927, "O", 26, "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", "Operación" },
                    { 928, "P", 26, "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", "Polinomio" },
                    { 929, "Q", 26, "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", "Quociente" },
                    { 930, "R", 26, "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", "Raíz" },
                    { 931, "S", 26, "Empieza por S: ¿Qué operación matemática se utiliza para combinar dos o más cantidades?", "Suma" },
                    { 932, "T", 26, "Empieza por T: ¿Qué función trigonométrica representa la razón entre el lado opuesto y el lado adyacente de un ángulo en un triángulo rectángulo?", "Tangente" },
                    { 933, "U", 26, "Empieza por U: ¿Qué término se utiliza para denotar una cantidad específica utilizada como estándar de medida?", "Unidad" },
                    { 934, "V", 26, "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", "Vector" },
                    { 935, "W", 26, "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", "Wronskiano" },
                    { 936, "X", 26, "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", "X-intercepto" },
                    { 937, "Y", 26, "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", "Y-intercepto" },
                    { 938, "Z", 26, "Empieza por Z: En inglés, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" },
                    { 939, "A", 46, "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", "Aritmética" },
                    { 940, "B", 46, "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", "Binomio" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 941, "C", 46, "Empieza por C: ¿Cuál es la disciplina matemática que estudia el cambio y la acumulación mediante límites, derivadas e integrales?", "Cálculo" },
                    { 942, "D", 46, "Empieza por D: ¿Qué concepto matemático representa la tasa de cambio instantáneo de una función?", "Derivada" },
                    { 943, "E", 46, "Empieza por E: ¿Cómo se llama una igualdad matemática que contiene una o más incógnitas?", "Ecuación" },
                    { 944, "F", 46, "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", "Función" },
                    { 945, "G", 46, "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños y las propiedades del espacio?", "Geometría" },
                    { 946, "H", 46, "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", "Hipotenusa" },
                    { 947, "I", 46, "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", "Integral" },
                    { 948, "J", 46, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" },
                    { 949, "K", 46, "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", "Kardinalidad" },
                    { 950, "L", 46, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" },
                    { 951, "M", 46, "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", "Matriz" },
                    { 952, "N", 46, "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", "Número" },
                    { 953, "O", 46, "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", "Operación" },
                    { 954, "P", 46, "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", "Polinomio" },
                    { 955, "Q", 46, "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", "Quociente" },
                    { 956, "R", 46, "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", "Raíz" },
                    { 957, "S", 46, "Empieza por S: ¿Qué operación matemática se utiliza para combinar dos o más cantidades?", "Suma" },
                    { 958, "T", 46, "Empieza por T: ¿Qué función trigonométrica representa la razón entre el lado opuesto y el lado adyacente de un ángulo en un triángulo rectángulo?", "Tangente" },
                    { 959, "U", 46, "Empieza por U: ¿Qué término se utiliza para denotar una cantidad específica utilizada como estándar de medida?", "Unidad" },
                    { 960, "V", 46, "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", "Vector" },
                    { 961, "W", 46, "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", "Wronskiano" },
                    { 962, "X", 46, "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", "X-intercepto" },
                    { 963, "Y", 46, "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", "Y-intercepto" },
                    { 964, "Z", 46, "Empieza por Z: En inglés, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" },
                    { 965, "A", 56, "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", "Aritmética" },
                    { 966, "B", 56, "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", "Binomio" },
                    { 967, "C", 56, "Empieza por C: ¿Cuál es la disciplina matemática que estudia el cambio y la acumulación mediante límites, derivadas e integrales?", "Cálculo" },
                    { 968, "D", 56, "Empieza por D: ¿Qué concepto matemático representa la tasa de cambio instantáneo de una función?", "Derivada" },
                    { 969, "E", 56, "Empieza por E: ¿Cómo se llama una igualdad matemática que contiene una o más incógnitas?", "Ecuación" },
                    { 970, "F", 56, "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", "Función" },
                    { 971, "G", 56, "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños y las propiedades del espacio?", "Geometría" },
                    { 972, "H", 56, "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", "Hipotenusa" },
                    { 973, "I", 56, "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", "Integral" },
                    { 974, "J", 56, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" },
                    { 975, "K", 56, "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", "Kardinalidad" },
                    { 976, "L", 56, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" },
                    { 977, "M", 56, "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", "Matriz" },
                    { 978, "N", 56, "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", "Número" },
                    { 979, "O", 56, "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", "Operación" },
                    { 980, "P", 56, "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", "Polinomio" },
                    { 981, "Q", 56, "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", "Quociente" },
                    { 982, "R", 56, "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", "Raíz" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 983, "S", 56, "Empieza por S: ¿Qué operación matemática se utiliza para combinar dos o más cantidades?", "Suma" },
                    { 984, "T", 56, "Empieza por T: ¿Qué función trigonométrica representa la razón entre el lado opuesto y el lado adyacente de un ángulo en un triángulo rectángulo?", "Tangente" },
                    { 985, "U", 56, "Empieza por U: ¿Qué término se utiliza para denotar una cantidad específica utilizada como estándar de medida?", "Unidad" },
                    { 986, "V", 56, "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", "Vector" },
                    { 987, "W", 56, "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", "Wronskiano" },
                    { 988, "X", 56, "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", "X-intercepto" },
                    { 989, "Y", 56, "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", "Y-intercepto" },
                    { 990, "Z", 56, "Empieza por Z: En inglés, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" },
                    { 991, "A", 17, "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", "Artículo" },
                    { 992, "B", 17, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 993, "C", 17, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 994, "D", 17, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 995, "E", 17, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 996, "F", 17, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 997, "G", 17, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 998, "H", 17, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" },
                    { 999, "I", 17, "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", "Interjección" },
                    { 1000, "J", 17, "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", "Juego" },
                    { 1001, "K", 17, "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", "Kiosco" },
                    { 1002, "L", 17, "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", "Letra" },
                    { 1003, "M", 17, "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", "Morfema" },
                    { 1004, "N", 17, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" },
                    { 1005, "O", 17, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 1006, "P", 17, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" },
                    { 1007, "Q", 17, "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", "Querido" },
                    { 1008, "R", 17, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" },
                    { 1009, "S", 17, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 1010, "T", 17, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 1011, "U", 17, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 1012, "V", 17, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 1013, "W", 17, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 1014, "X", 17, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" },
                    { 1015, "Y", 17, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 1016, "Z", 17, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" },
                    { 1017, "A", 27, "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", "Artículo" },
                    { 1018, "B", 27, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 1019, "C", 27, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 1020, "D", 27, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 1021, "E", 27, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 1022, "F", 27, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 1023, "G", 27, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 1024, "H", 27, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1025, "I", 27, "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", "Interjección" },
                    { 1026, "J", 27, "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", "Juego" },
                    { 1027, "K", 27, "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", "Kiosco" },
                    { 1028, "L", 27, "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", "Letra" },
                    { 1029, "M", 27, "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", "Morfema" },
                    { 1030, "N", 27, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" },
                    { 1031, "O", 27, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 1032, "P", 27, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" },
                    { 1033, "Q", 27, "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", "Querido" },
                    { 1034, "R", 27, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" },
                    { 1035, "S", 27, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 1036, "T", 27, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 1037, "U", 27, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 1038, "V", 27, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 1039, "W", 27, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 1040, "X", 27, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" },
                    { 1041, "Y", 27, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 1042, "Z", 27, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" },
                    { 1043, "A", 37, "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", "Artículo" },
                    { 1044, "B", 37, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 1045, "C", 37, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 1046, "D", 37, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 1047, "E", 37, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 1048, "F", 37, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 1049, "G", 37, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 1050, "H", 37, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" },
                    { 1051, "I", 37, "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", "Interjección" },
                    { 1052, "J", 37, "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", "Juego" },
                    { 1053, "K", 37, "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", "Kiosco" },
                    { 1054, "L", 37, "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", "Letra" },
                    { 1055, "M", 37, "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", "Morfema" },
                    { 1056, "N", 37, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" },
                    { 1057, "O", 37, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 1058, "P", 37, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" },
                    { 1059, "Q", 37, "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", "Querido" },
                    { 1060, "R", 37, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" },
                    { 1061, "S", 37, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 1062, "T", 37, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 1063, "U", 37, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 1064, "V", 37, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 1065, "W", 37, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 1066, "X", 37, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1067, "Y", 37, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 1068, "Z", 37, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" },
                    { 1069, "A", 47, "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", "Artículo" },
                    { 1070, "B", 47, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 1071, "C", 47, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 1072, "D", 47, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 1073, "E", 47, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 1074, "F", 47, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 1075, "G", 47, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 1076, "H", 47, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" },
                    { 1077, "I", 47, "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", "Interjección" },
                    { 1078, "J", 47, "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", "Juego" },
                    { 1079, "K", 47, "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", "Kiosco" },
                    { 1080, "L", 47, "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", "Letra" },
                    { 1081, "M", 47, "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", "Morfema" },
                    { 1082, "N", 47, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" },
                    { 1083, "O", 47, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 1084, "P", 47, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" },
                    { 1085, "Q", 47, "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", "Querido" },
                    { 1086, "R", 47, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" },
                    { 1087, "S", 47, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 1088, "T", 47, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 1089, "U", 47, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 1090, "V", 47, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 1091, "W", 47, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 1092, "X", 47, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" },
                    { 1093, "Y", 47, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 1094, "Z", 47, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" },
                    { 1095, "A", 57, "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", "Artículo" },
                    { 1096, "B", 57, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" },
                    { 1097, "C", 57, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 1098, "D", 57, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 1099, "E", 57, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 1100, "F", 57, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 1101, "G", 57, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 1102, "H", 57, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" },
                    { 1103, "I", 57, "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", "Interjección" },
                    { 1104, "J", 57, "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", "Juego" },
                    { 1105, "K", 57, "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", "Kiosco" },
                    { 1106, "L", 57, "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", "Letra" },
                    { 1107, "M", 57, "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", "Morfema" },
                    { 1108, "N", 57, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1109, "O", 57, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 1110, "P", 57, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" },
                    { 1111, "Q", 57, "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", "Querido" },
                    { 1112, "R", 57, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" },
                    { 1113, "S", 57, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 1114, "T", 57, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 1115, "U", 57, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 1116, "V", 57, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 1117, "W", 57, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 1118, "X", 57, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" },
                    { 1119, "Y", 57, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 1120, "Z", 57, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ahorcados_IdJuego",
                table: "Ahorcados",
                column: "IdJuego",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdAsignatura",
                table: "Juegos",
                column: "IdAsignatura");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdCurso",
                table: "Juegos",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_IdTipoJuego",
                table: "Juegos",
                column: "IdTipoJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Pasapalabras_IdJuego",
                table: "Pasapalabras",
                column: "IdJuego",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreguntaAhorcados_AhorcadoId",
                table: "PreguntaAhorcados",
                column: "AhorcadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreguntaPasapalabras_PasapalabraId",
                table: "PreguntaPasapalabras",
                column: "PasapalabraId");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_IdJuego",
                table: "Resultados",
                column: "IdJuego");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_IdUsuario",
                table: "Resultados",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AvatarId",
                table: "Usuarios",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreguntaAhorcados");

            migrationBuilder.DropTable(
                name: "PreguntaPasapalabras");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Ahorcados");

            migrationBuilder.DropTable(
                name: "Pasapalabras");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Avatars");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "TipoJuegos");
        }
    }
}
