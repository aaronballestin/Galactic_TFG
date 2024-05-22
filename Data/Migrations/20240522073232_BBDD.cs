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
                    { 8, null, "XXXXXX", 1, 1, 1, "Lengua - 2" },
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
                    { 12, "L", 1, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" },
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
                    { 53, "A", 3, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 54, "B", 3, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
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
                    { 171, "N", 7, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
                    { 184, "Z", 7, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" },
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
                    { 214, "D", 9, "¿Qué actividad implica plasmar ideas en papel?", "Dibujo" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
                    { 226, "P", 9, "¿Sobre qué se pueden realizar dibujos o manualidades?", "Papel" },
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
                    { 256, "T", 10, "¿Qué instrumento de percusión se golpea para producir sonidos?", "Tambor" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 257, "U", 10, "¿Qué instrumento tiene cuatro cuerdas y se toca con los dedos o con un plectro?", "Ukelele" },
                    { 258, "V", 10, "¿Qué instrumento de cuerda se toca frotando las cuerdas con un arco?", "Violín" },
                    { 259, "W", 10, "¿Qué instrumento se utiliza para hacer sonidos agudos soplando?", "Whistle" },
                    { 260, "X", 10, "¿Qué instrumento de percusión tiene láminas que se golpean para producir sonido?", "Xilófono" },
                    { 261, "Y", 10, "¿Qué parte de la baqueta se utiliza para golpear un tambor?", "Yema" },
                    { 262, "Z", 10, "¿Qué tipo de patrón se forma con líneas que se juntan y separan de forma zigzagueante?", "Zigzag" }
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
