using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 2,
                column: "NombreAsignatura",
                value: "Matemáticas");

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 5,
                column: "NombreAsignatura",
                value: "Inglés");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 4,
                column: "TemaJuego",
                value: "Inglés Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 5,
                column: "TemaJuego",
                value: "Inglés Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 6,
                column: "TemaJuego",
                value: "Matemáticas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 10,
                column: "TemaJuego",
                value: "Música");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 14,
                column: "TemaJuego",
                value: "Inglés Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 15,
                column: "TemaJuego",
                value: "Inglés Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 16,
                column: "TemaJuego",
                value: "Matemáticas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 24,
                column: "TemaJuego",
                value: "Inglés Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 25,
                column: "TemaJuego",
                value: "Inglés Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 26,
                column: "TemaJuego",
                value: "Matemáticas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 34,
                column: "TemaJuego",
                value: "Inglés Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 35,
                column: "TemaJuego",
                value: "Inglés Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 36,
                column: "TemaJuego",
                value: "Matemáticas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 44,
                column: "TemaJuego",
                value: "Inglés Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 45,
                column: "TemaJuego",
                value: "Inglés Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 46,
                column: "TemaJuego",
                value: "Matemáticas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 56,
                column: "TemaJuego",
                value: "Matemáticas - General");

            migrationBuilder.UpdateData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acertadas", "IdUsuario", "Resultado" },
                values: new object[] { 27, 3, 100.0 });

            migrationBuilder.InsertData(
                table: "TipoJuegos",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 2, "Ahorcado" });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Codigo", "IdAsignatura", "IdCurso", "IdTipoJuego", "TemaJuego" },
                values: new object[,]
                {
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

            migrationBuilder.CreateIndex(
                name: "IX_Ahorcados_IdJuego",
                table: "Ahorcados",
                column: "IdJuego",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreguntaAhorcados_AhorcadoId",
                table: "PreguntaAhorcados",
                column: "AhorcadoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreguntaAhorcados");

            migrationBuilder.DropTable(
                name: "Ahorcados");

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TipoJuegos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 2,
                column: "NombreAsignatura",
                value: "Matematicas");

            migrationBuilder.UpdateData(
                table: "Asignaturas",
                keyColumn: "Id",
                keyValue: 5,
                column: "NombreAsignatura",
                value: "Ingles");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 4,
                column: "TemaJuego",
                value: "Ingles Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 5,
                column: "TemaJuego",
                value: "Ingles Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 6,
                column: "TemaJuego",
                value: "Matematicas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 10,
                column: "TemaJuego",
                value: "Musica");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 14,
                column: "TemaJuego",
                value: "Ingles Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 15,
                column: "TemaJuego",
                value: "Ingles Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 16,
                column: "TemaJuego",
                value: "Matematicas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 24,
                column: "TemaJuego",
                value: "Ingles Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 25,
                column: "TemaJuego",
                value: "Ingles Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 26,
                column: "TemaJuego",
                value: "Matematicas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 34,
                column: "TemaJuego",
                value: "Ingles Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 35,
                column: "TemaJuego",
                value: "Ingles Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 36,
                column: "TemaJuego",
                value: "Matematicas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 44,
                column: "TemaJuego",
                value: "Ingles Basic - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 45,
                column: "TemaJuego",
                value: "Ingles Animals - 1");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 46,
                column: "TemaJuego",
                value: "Matematicas - General");

            migrationBuilder.UpdateData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 56,
                column: "TemaJuego",
                value: "Matematicas - General");

            migrationBuilder.UpdateData(
                table: "Resultados",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acertadas", "IdUsuario", "Resultado" },
                values: new object[] { 0, 1, 0.0 });
        }
    }
}
