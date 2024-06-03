using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    public partial class BBDD2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 263, "A", 11, "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", "Asia" },
                    { 264, "B", 11, "Empieza por B: Capital de Alemania, famosa por su Muro", "Berlín" },
                    { 265, "C", 11, "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", "Chile" },
                    { 266, "D", 11, "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", "Dinamarca" },
                    { 267, "E", 11, "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", "Egipto" },
                    { 268, "F", 11, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" },
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
                    { 304, "P", 21, "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", "Portugal" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 305, "Q", 21, "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", "Qatar" },
                    { 306, "R", 21, "Empieza por R: País más grande del mundo, situado en Europa y Asia", "Rusia" },
                    { 307, "S", 21, "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", "Suecia" },
                    { 308, "T", 21, "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", "Tailandia" },
                    { 309, "U", 21, "Empieza por U: País de Europa del Este cuya capital es Kiev", "Ucrania" },
                    { 310, "V", 21, "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", "Vietnam" },
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
                    { 346, "F", 41, "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", "Francia" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 347, "G", 41, "Empieza por G: País de América Central cuyo nombre rima con 'mala'", "Guatemala" },
                    { 348, "H", 41, "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", "Honduras" },
                    { 349, "I", 41, "Empieza por I: País europeo conocido por su forma de bota", "Italia" },
                    { 350, "J", 41, "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", "Japón" },
                    { 351, "K", 41, "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", "Kazajistán" },
                    { 352, "L", 41, "Empieza por L: País báltico de Europa cuya capital es Vilna", "Lituania" },
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
                    { 388, "V", 12, "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", "Violín" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 389, "W", 12, "Empieza por W: Nombre de un famoso parque de atracciones en Florida", "Walt Disney World" },
                    { 390, "X", 12, "Empieza por X: Nombre de un instrumento de percusión con placas de madera", "Xilófono" },
                    { 391, "Y", 12, "Empieza por Y: Nombre de un río muy largo en China", "Yangtsé" },
                    { 392, "Z", 12, "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", "Zebra" },
                    { 393, "A", 22, "Empieza por A: Nombre de un animal volador conocido por su aguda visión", "Águila" },
                    { 394, "B", 22, "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", "Banana" },
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
                    { 430, "L", 32, "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", "Laúd" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 431, "M", 32, "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", "Mediterráneo" },
                    { 432, "N", 32, "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", "Nieve" },
                    { 433, "O", 32, "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", "Orca" },
                    { 434, "P", 32, "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", "Portugal" },
                    { 435, "Q", 32, "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", "Quino" },
                    { 436, "R", 32, "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", "Rectángulo" },
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
                    { 472, "B", 13, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 473, "C", 13, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 474, "D", 13, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
                    { 475, "E", 13, "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", "Ecosistema" },
                    { 476, "F", 13, "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", "Fotosíntesis" },
                    { 477, "G", 13, "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", "Gravedad" },
                    { 478, "H", 13, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" },
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
                    { 514, "R", 13, "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", "Raíz" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 515, "S", 13, "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", "Luna" },
                    { 516, "T", 13, "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", "Temperatura" },
                    { 517, "U", 13, "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", "Urano" },
                    { 518, "V", 13, "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", "Volcán" },
                    { 519, "W", 13, "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", "Vatios" },
                    { 520, "X", 13, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" },
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
                    { 556, "H", 33, "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", "Hueso" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 557, "I", 33, "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", "Imán" },
                    { 558, "J", 33, "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", "Jirafa" },
                    { 559, "K", 33, "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", "Kilogramo" },
                    { 560, "L", 33, "Empieza por L: ¿Qué necesitamos para ver las cosas?", "Luz" },
                    { 561, "M", 33, "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", "Molécula" },
                    { 562, "N", 33, "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", "Nutriente" },
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
                    { 598, "X", 43, "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", "Xilema" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 599, "Y", 43, "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", "Yema" },
                    { 600, "Z", 43, "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", "Zoológico" },
                    { 601, "A", 53, "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", "Agua" },
                    { 602, "B", 53, "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", "Biosfera" },
                    { 603, "C", 53, "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", "Célula" },
                    { 604, "D", 53, "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", "Dinosaurio" },
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
                    { 640, "N", 14, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 641, "O", 14, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 642, "P", 14, "Empieza por P: A large mammal known for its trunk", "Elephant" },
                    { 643, "Q", 14, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 644, "R", 14, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 645, "S", 14, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 646, "T", 14, "Empieza por T: The opposite of 'short'", "Tall" },
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
                    { 682, "D", 34, "Empieza por D: The opposite of 'night'", "Day" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 683, "E", 34, "Empieza por E: The planet we live on", "Earth" },
                    { 684, "F", 34, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
                    { 685, "G", 34, "Empieza por G: A color made by mixing blue and yellow", "Green" },
                    { 686, "H", 34, "Empieza por H: A common household pet that purrs", "Cat" },
                    { 687, "I", 34, "Empieza por I: Frozen water", "Ice" },
                    { 688, "J", 34, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" },
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
                    { 724, "T", 44, "Empieza por T: The opposite of 'short'", "Tall" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 725, "U", 44, "Empieza por U: The color of a clear sky", "Blue" },
                    { 726, "V", 44, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
                    { 727, "W", 44, "Empieza por W: The opposite of 'dry'", "Wet" },
                    { 728, "X", 44, "Empieza por X: A musical instrument that has wooden bars and is played with mallets", "Xylophone" },
                    { 729, "Y", 44, "Empieza por Y: A color that is the opposite of 'blue'", "Yellow" },
                    { 730, "Z", 44, "Empieza por Z: A wild animal with black and white stripes", "Zebra" },
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
                    { 766, "J", 15, "Empieza por J: A sweet, red fruit often used to make jam", "Strawberry" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 767, "K", 15, "Empieza por K: A large bird that cannot fly and is native to Australia", "Koala" },
                    { 768, "L", 15, "Empieza por L: The opposite of 'dark'", "Light" },
                    { 769, "M", 15, "Empieza por M: A small, furry animal that lives in houses and likes cheese", "Mouse" },
                    { 770, "N", 15, "Empieza por N: The time of day when it is dark and people usually sleep", "Night" },
                    { 771, "O", 15, "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", "Pineapple" },
                    { 772, "P", 15, "Empieza por P: A large mammal known for its trunk", "Elephant" },
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
                    { 808, "Z", 25, "Empieza por Z: A wild animal with black and white stripes", "Zebra" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 809, "A", 35, "Empieza por A: An animal that can fly and is known for its colorful feathers", "Ara" },
                    { 810, "B", 35, "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", "Bear" },
                    { 811, "C", 35, "Empieza por C: A round, orange vegetable often used in soups and pies", "Carrot" },
                    { 812, "D", 35, "Empieza por D: The opposite of 'night'", "Day" },
                    { 813, "E", 35, "Empieza por E: The planet we live on", "Earth" },
                    { 814, "F", 35, "Empieza por F: What bird is known for its pink feathers and long legs?", "Flamingo" },
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
                    { 850, "P", 45, "Empieza por P: A large mammal known for its trunk", "Elephant" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 851, "Q", 45, "Empieza por Q: A flying insect known for its painful sting", "Wasp" },
                    { 852, "R", 45, "Empieza por R: A large, round fruit that is often red or green and very juicy", "Watermelon" },
                    { 853, "S", 45, "Empieza por S: The opposite of 'slow'", "Fast" },
                    { 854, "T", 45, "Empieza por T: The opposite of 'short'", "Tall" },
                    { 855, "U", 45, "Empieza por U: The color of a clear sky", "Blue" },
                    { 856, "V", 45, "Empieza por V: A fruit that is often dried and used in cereals", "Raisin" },
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
                    { 892, "F", 16, "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", "Función" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 893, "G", 16, "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños, y las propiedades del espacio?", "Geometría" },
                    { 894, "H", 16, "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", "Hipotenusa" },
                    { 895, "I", 16, "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", "Integral" },
                    { 896, "J", 16, "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", "Juego de números" },
                    { 897, "K", 16, "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", "Kardinalidad" },
                    { 898, "L", 16, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" },
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
                    { 934, "V", 26, "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", "Vector" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 935, "W", 26, "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", "Wronskiano" },
                    { 936, "X", 26, "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", "X-intercepto" },
                    { 937, "Y", 26, "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", "Y-intercepto" },
                    { 938, "Z", 26, "Empieza por Z: En inglés, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", "Zero (cero)" },
                    { 939, "A", 46, "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", "Aritmética" },
                    { 940, "B", 46, "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", "Binomio" },
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
                    { 976, "L", 56, "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", "Logaritmo" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 977, "M", 56, "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", "Matriz" },
                    { 978, "N", 56, "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", "Número" },
                    { 979, "O", 56, "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", "Operación" },
                    { 980, "P", 56, "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", "Polinomio" },
                    { 981, "Q", 56, "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", "Quociente" },
                    { 982, "R", 56, "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", "Raíz" },
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
                    { 1018, "B", 27, "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", "Biografía" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1019, "C", 27, "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", "Conjunción" },
                    { 1020, "D", 27, "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", "Diptongo" },
                    { 1021, "E", 27, "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", "Escritura" },
                    { 1022, "F", 27, "Empieza por F: ¿Qué representa los sonidos básicos del habla?", "Fonema" },
                    { 1023, "G", 27, "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", "Gramática" },
                    { 1024, "H", 27, "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", "Homófono" },
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
                    { 1060, "R", 37, "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", "Rima" }
                });

            migrationBuilder.InsertData(
                table: "PreguntaPasapalabras",
                columns: new[] { "Id", "Letra", "PasapalabraId", "Pregunta", "Respuesta" },
                values: new object[,]
                {
                    { 1061, "S", 37, "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", "Sujeto" },
                    { 1062, "T", 37, "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", "Trabalenguas" },
                    { 1063, "U", 37, "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", "Uso" },
                    { 1064, "V", 37, "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", "Vocabulario" },
                    { 1065, "W", 37, "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", "Watusi" },
                    { 1066, "X", 37, "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", "Xilófono" },
                    { 1067, "Y", 37, "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", "Yod" },
                    { 1068, "Z", 37, "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", "Zona" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "PreguntaPasapalabras",
                keyColumn: "Id",
                keyValue: 1068);
        }
    }
}
