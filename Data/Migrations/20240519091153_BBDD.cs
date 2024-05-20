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
                name: "AsignaturaJuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuegoAsignatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAsignatura = table.Column<int>(type: "int", nullable: false),
                    IdTipoJuego = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    TipoJuegoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignaturaJuegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignaturaJuegos_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignaturaJuegos_TipoJuegos_TipoJuegoId",
                        column: x => x.TipoJuegoId,
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
                    IdAsignatura = table.Column<int>(type: "int", nullable: false),
                    IdCurso = table.Column<int>(type: "int", nullable: false),
                    IdTipoJuego = table.Column<int>(type: "int", nullable: false),
                    AsignaturaJuegoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Juegos_AsignaturaJuegos_AsignaturaJuegoId",
                        column: x => x.AsignaturaJuegoId,
                        principalTable: "AsignaturaJuegos",
                        principalColumn: "Id");
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
                table: "Asignaturas",
                columns: new[] { "Id", "NombreAsignatura" },
                values: new object[,]
                {
                    { 1, "Lengua" },
                    { 2, "Matematicas" },
                    { 3, "Conocimiento del medio" },
                    { 4, "Educación Artística" },
                    { 5, "Ingles" }
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
                table: "Juegos",
                columns: new[] { "Id", "AsignaturaJuegoId", "Codigo", "IdAsignatura", "IdCurso", "IdTipoJuego", "TemaJuego" },
                values: new object[,]
                {
                    { 1, null, "XXXXXX", 3, 1, 1, "Geografía Basica" },
                    { 2, null, "XXXXXX", 3, 1, 1, "Cultura General - 1" },
                    { 3, null, "XXXXXX", 3, 1, 1, "Cultura General - 2" },
                    { 4, null, "XXXXXX", 5, 1, 1, "Ingles Basic - 1" },
                    { 5, null, "XXXXXX", 5, 1, 1, "Ingles Animals - 1" },
                    { 6, null, "XXXXXX", 2, 1, 1, "Matematicas - General" },
                    { 7, null, "XXXXXX", 1, 1, 1, "Lengua - 1" },
                    { 8, null, "XXXXXX", 1, 1, 1, "Lengua - 1" },
                    { 9, null, "XXXXXX", 4, 1, 1, "Plastica" },
                    { 10, null, "XXXXXX", 4, 1, 1, "Musica" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AvatarId", "Email", "Name", "Password", "Rol" },
                values: new object[,]
                {
                    { 1, 1, "aaron@svalero.com", "Aaron", "1234", "Admin" },
                    { 2, 1, "antonio@svalero.com", "Antonio", "1234", "Profesor" },
                    { 3, 1, "alex@svalero.com", "Alex", "1234", "Alumno" }
                });

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Geografía" },
                    { 2, 2, "Nombres de otras cosas pasapalabra" },
                    { 3, 3, "Nombres de otras cosas pasapalabra" },
                    { 4, 4, "Nombres de otras cosas pasapalabra" },
                    { 5, 5, "Nombres de otras cosas pasapalabra" },
                    { 6, 6, "Nombres de otras cosas pasapalabra" },
                    { 7, 7, "Nombres de otras cosas pasapalabra" },
                    { 8, 8, "Nombres de otras cosas pasapalabra" },
                    { 9, 9, "Nombres de otras cosas pasapalabra" },
                    { 10, 10, "Nombres de otras cosas pasapalabra" }
                });

            migrationBuilder.InsertData(
                table: "resultados",
                columns: new[] { "Id", "IdJuego", "IdUsuario", "Resultado" },
                values: new object[] { 1, 1, 1, 0.0 });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1, "A", 1, "Empieza por A: Continente al este de Europa ", "Asia" },
                    { 2, "B", 1, "Empieza por B: Capital de Alemania ", "Berlín" },
                    { 3, "C", 1, "Empieza por C: País de América del Sur ", "Chile" },
                    { 4, "D", 1, "Empieza por D: País de Europa ", "Dinamarca" },
                    { 5, "E", 1, "Empieza por E: País de África que es famoso por sus pirámides", "Egipto" },
                    { 6, "F", 1, "Empieza por F: País de Europa ", "Francia" },
                    { 7, "G", 1, "Empieza por G: País de América del Norte que", "Guatemala" },
                    { 8, "H", 1, "Empieza por H: País de América Central ", "Honduras" },
                    { 9, "I", 1, "Empieza por I: País de Europa ", "Italia" },
                    { 10, "J", 1, "Empieza por J:  País de Asia ", "Japón" },
                    { 11, "K", 1, "Empieza por K:  País de Asia ", "Kazajistán" },
                    { 12, "L", 1, "Empieza por L: País de Europa ", "Lituania" },
                    { 13, "M", 1, "Empieza por M:  País de África ", "Marruecos" },
                    { 14, "N", 1, "Empieza por N: País de Europa ", "Noruega" },
                    { 15, "O", 1, "Empieza por O:  País de Asia ", "Omán" },
                    { 16, "P", 1, "Empieza por P: País de Europa ", "Portugal" },
                    { 17, "Q", 1, "Empieza por Q: País de Asia ", "Qatar" },
                    { 18, "R", 1, "Empieza por R: País de Europa", "Rusia" },
                    { 19, "S", 1, "Empieza por S: País de Europa", "Suecia" },
                    { 20, "T", 1, "Empieza por T: País de Asia ", "Tailandia" },
                    { 21, "U", 1, "Empieza por U: País de Europa ", "Ucrania" },
                    { 22, "V", 1, "Empieza por V: País de Asia que", "Vietnam" },
                    { 23, "W", 1, "Empieza por W: País de Oceanía", "Wallis y Futuna" },
                    { 24, "X", 1, "Empieza por X: Ciudad de China", "Xi'an" },
                    { 25, "Y", 1, "Empieza por Y: País de Asia ", "Yemen" },
                    { 26, "Z", 1, "Empieza por Z: País de África", "Zambia" },
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
                    { 42, "P", 2, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
                    { 53, "A", 3, "Empieza por A: Nombre de un famoso científico que desarrolló la teoría de la relatividad", "Einstein" },
                    { 54, "B", 3, "Empieza por B: Nombre de una danza tradicional argentina y uruguaya", "Bailongo" },
                    { 55, "C", 3, "Empieza por C: Nombre del inventor del teléfono", "Bell" },
                    { 56, "D", 3, "Empieza por D: Nombre del pintor surrealista español conocido por sus excéntricas obras", "Dalí" },
                    { 57, "E", 3, "Empieza por E: Nombre del mayor océano del mundo", "Pacífico" },
                    { 58, "F", 3, "Empieza por F: Nombre del autor del libro 'El principito'", "Saint-Exupéry" },
                    { 59, "G", 3, "Empieza por G: Nombre del metal más ligero", "Litio" },
                    { 60, "H", 3, "Empieza por H: Nombre de la isla donde se encuentra la estatua del Cristo Redentor", "Corcovado" },
                    { 61, "I", 3, "Empieza por I: Nombre de un famoso arquitecto español conocido por su obra 'La Sagrada Familia'", "Gaudí" },
                    { 62, "J", 3, "Empieza por J: Nombre de un famoso tenista suizo", "Federer" },
                    { 63, "K", 3, "Empieza por K: Nombre del presidente de Estados Unidos asesinado en 1963", "Kennedy" },
                    { 64, "L", 3, "Empieza por L: Nombre del mayor lago de agua dulce en África", "Victoria" },
                    { 65, "M", 3, "Empieza por M: Nombre de una famosa cadena de montañas en Sudamérica", "Andes" },
                    { 66, "N", 3, "Empieza por N: Nombre del autor de la novela 'Moby-Dick'", "Melville" },
                    { 67, "O", 3, "Empieza por O: Nombre del único mamífero que puede volar", "Murciélago" },
                    { 68, "P", 3, "Empieza por P: Nombre de la ciudad italiana famosa por su torre inclinada", "Pisa" },
                    { 69, "Q", 3, "Empieza por Q: Nombre del ave nacional de Guatemala", "Quetzal" },
                    { 70, "R", 3, "Empieza por R: Nombre del mayor desierto cálido del mundo", "Sahara" },
                    { 71, "S", 3, "Empieza por S: Nombre del satélite natural de la Tierra", "Luna" },
                    { 72, "T", 3, "Empieza por T: Nombre del lugar donde se realiza el festival de la flor de cerezos", "Japón" },
                    { 73, "U", 3, "Empieza por U: Nombre del país conocido por el Machu Picchu", "Perú" },
                    { 74, "V", 3, "Empieza por V: Nombre del pintor que cortó su propia oreja", "Van Gogh" },
                    { 75, "W", 3, "Empieza por W: Nombre del lugar donde se encuentra la Casa Blanca", "Washington, D.C." },
                    { 76, "X", 3, "Empieza por X: Nombre de la técnica de imagen médica que usa radiación", "Rayos X" },
                    { 77, "Y", 3, "Empieza por Y: Nombre de la flor nacional de Japón", "Crisantemo" },
                    { 78, "Z", 3, "Empieza por Z: Nombre de un mineral precioso de color azul", "Zafiro" },
                    { 79, "A", 4, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Parrot" },
                    { 80, "B", 4, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Hippo" },
                    { 81, "C", 4, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 82, "D", 4, "Empieza por D: The opposite of 'night'", "Day" },
                    { 83, "E", 4, "Empieza por E: The planet we live on", "Earth" },
                    { 84, "F", 4, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
                    { 96, "R", 4, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
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
                    { 128, "X", 5, "Empieza por X: A small mammal native to Africa", "Xerus" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
                    { 140, "J", 6, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" },
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
                    { 157, "Z", 6, "Empieza por Z: En ingles, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_AsignaturaId",
                table: "AsignaturaJuegos",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignaturaJuegos_TipoJuegoId",
                table: "AsignaturaJuegos",
                column: "TipoJuegoId");

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
                name: "IX_Juegos_IdTipoJuego",
                table: "Juegos",
                column: "IdTipoJuego");

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
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "TipoJuegos");
        }
    }
}
