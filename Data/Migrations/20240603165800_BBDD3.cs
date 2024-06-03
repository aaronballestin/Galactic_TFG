using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pasapalabras",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
                    { 1108, "N", 57, "Empieza por N: ¿Qué persona cuenta una historia o relato?", "Narrador" },
                    { 1109, "O", 57, "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", "Oración" },
                    { 1110, "P", 57, "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", "Palabra" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.InsertData(
                table: "Pasapalabras",
                columns: new[] { "Id", "IdJuego", "Name" },
                values: new object[,]
                {
                    { 9, 9, "Plástica" },
                    { 10, 10, "Musica" },
                    { 19, 19, "Nombres de otras cosas pasapalabra" },
                    { 20, 20, "Nombres de otras cosas pasapalabra" },
                    { 29, 29, "Nombres de otras cosas pasapalabra" },
                    { 30, 30, "Nombres de otras cosas pasapalabra" },
                    { 38, 38, "Nombres de otras cosas pasapalabra" },
                    { 39, 39, "Nombres de otras cosas pasapalabra" },
                    { 40, 40, "Nombres de otras cosas pasapalabra" },
                    { 48, 48, "Nombres de otras cosas pasapalabra" },
                    { 49, 49, "Nombres de otras cosas pasapalabra" },
                    { 50, 50, "Nombres de otras cosas pasapalabra" },
                    { 58, 58, "Nombres de otras cosas pasapalabra" },
                    { 59, 59, "Nombres de otras cosas pasapalabra" },
                    { 60, 60, "Nombres de otras cosas pasapalabra" }
                });
        }
    }
}
