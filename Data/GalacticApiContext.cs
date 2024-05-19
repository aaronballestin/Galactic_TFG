using Microsoft.EntityFrameworkCore;
using GalacticApi.Models;
using Microsoft.Extensions.Configuration;
using System;
namespace GalacticApi.Data
{
    public class GalacticApiContext : DbContext
    {
        public GalacticApiContext(DbContextOptions<GalacticApiContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Name = "Aaron", Email = "aaron@svalero.com", Password = "1234", AvatarId = 1, Rol = "Admin" },
                new Usuario { Id = 2, Name = "Antonio", Email = "antonio@svalero.com", Password = "1234", AvatarId = 1, Rol = "Profesor" },
                new Usuario { Id = 3, Name = "Alex", Email = "alex@svalero.com", Password = "1234", AvatarId = 1, Rol = "Alumno" }

            );

            modelBuilder.Entity<Avatar>().HasData(
                new Avatar { Id = 1, RutaFoto = "", CodigoJuego = "XXXXXX", Premium = 'N' }
            );

            modelBuilder.Entity<Curso>().HasData(
                new Curso { CursoId = 1, NombreCurso = "1º Primaria" },
                new Curso { CursoId = 2, NombreCurso = "2º Primaria" },
                new Curso { CursoId = 3, NombreCurso = "3º Primaria" },
                new Curso { CursoId = 4, NombreCurso = "4º Primaria" },
                new Curso { CursoId = 5, NombreCurso = "5º Primaria" },
                new Curso { CursoId = 6, NombreCurso = "6º Primaria" }
            );

            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura { Id = 1, NombreAsignatura = "Lengua" },
                new Asignatura { Id = 2, NombreAsignatura = "Matematicas" },
                new Asignatura { Id = 3, NombreAsignatura = "Conocimiento del medio" },
                new Asignatura { Id = 4, NombreAsignatura = "Educación Artística" },
                new Asignatura { Id = 5, NombreAsignatura = "Ingles" }

            );

            modelBuilder.Entity<TipoJuego>().HasData(
                new TipoJuego { Id = 1, Tipo = "Pasapalabra" }
            );


            modelBuilder.Entity<Juego>().HasData(
                new Juego { Id = 1, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Geografía Basica", Codigo = "XXXXXX" },
                new Juego { Id = 2, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 1", Codigo = "XXXXXX" },
                new Juego { Id = 3, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 2", Codigo = "XXXXXX" },
                new Juego { Id = 4, IdCurso = 1, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Basic - 1", Codigo = "XXXXXX" },
                new Juego { Id = 5, IdCurso = 1, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Animals - 1", Codigo = "XXXXXX" },
                new Juego { Id = 6, IdCurso = 1, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Matematicas - General", Codigo = "XXXXXX" },
                new Juego { Id = 7, IdCurso = 1, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 8, IdCurso = 1, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 9, IdCurso = 1, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 10, IdCurso = 1, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" }

            );

            modelBuilder.Entity<Resultados>().HasData(
                new Resultados { Id = 1, IdJuego = 1, IdUsuario = 1, Resultado = 0.00 }
            );

            modelBuilder.Entity<Pasapalabra>().HasData(
                new Pasapalabra { Id = 1, Name = "Geografía", IdJuego = 1 },
                new Pasapalabra { Id = 2, Name = "Nombres de otras cosas pasapalabra", IdJuego = 2 },
                new Pasapalabra { Id = 3, Name = "Nombres de otras cosas pasapalabra", IdJuego = 3 },
                new Pasapalabra { Id = 4, Name = "Nombres de otras cosas pasapalabra", IdJuego = 4 },
                new Pasapalabra { Id = 5, Name = "Nombres de otras cosas pasapalabra", IdJuego = 5 },
                new Pasapalabra { Id = 6, Name = "Nombres de otras cosas pasapalabra", IdJuego = 6 },
                new Pasapalabra { Id = 7, Name = "Nombres de otras cosas pasapalabra", IdJuego = 7 },
                new Pasapalabra { Id = 8, Name = "Nombres de otras cosas pasapalabra", IdJuego = 8 },
                new Pasapalabra { Id = 9, Name = "Nombres de otras cosas pasapalabra", IdJuego = 9 },
                new Pasapalabra { Id = 10, Name = "Nombres de otras cosas pasapalabra", IdJuego = 10 }


            );

            modelBuilder.Entity<PreguntaPasapalabra>().HasData(
                new PreguntaPasapalabra { Id = 1, PasapalabraId = 1, Letra = 'A', Pregunta = "Empieza por A: Continente al este de Europa ", Respuesta = "Asia" },
                new PreguntaPasapalabra { Id = 2, PasapalabraId = 1, Letra = 'B', Pregunta = "Empieza por B: Capital de Alemania ", Respuesta = "Berlín" },
                new PreguntaPasapalabra { Id = 3, PasapalabraId = 1, Letra = 'C', Pregunta = "Empieza por C: País de América del Sur ", Respuesta = "Chile" },
                new PreguntaPasapalabra { Id = 4, PasapalabraId = 1, Letra = 'D', Pregunta = "Empieza por D: País de Europa ", Respuesta = "Dinamarca" },
                new PreguntaPasapalabra { Id = 5, PasapalabraId = 1, Letra = 'E', Pregunta = "Empieza por E: País de África que es famoso por sus pirámides", Respuesta = "Egipto" },
                new PreguntaPasapalabra { Id = 6, PasapalabraId = 1, Letra = 'F', Pregunta = "Empieza por F: País de Europa ", Respuesta = "Francia" },
                new PreguntaPasapalabra { Id = 7, PasapalabraId = 1, Letra = 'G', Pregunta = "Empieza por G: País de América del Norte que", Respuesta = "Guatemala" },
                new PreguntaPasapalabra { Id = 8, PasapalabraId = 1, Letra = 'H', Pregunta = "Empieza por H: País de América Central ", Respuesta = "Honduras" },
                new PreguntaPasapalabra { Id = 9, PasapalabraId = 1, Letra = 'I', Pregunta = "Empieza por I: País de Europa ", Respuesta = "Italia" },
                new PreguntaPasapalabra { Id = 10, PasapalabraId = 1, Letra = 'J', Pregunta = "Empieza por J:  País de Asia ", Respuesta = "Japón" },
                new PreguntaPasapalabra { Id = 11, PasapalabraId = 1, Letra = 'K', Pregunta = "Empieza por K:  País de Asia ", Respuesta = "Kazajistán" },
                new PreguntaPasapalabra { Id = 12, PasapalabraId = 1, Letra = 'L', Pregunta = "Empieza por L: País de Europa ", Respuesta = "Lituania" },
                new PreguntaPasapalabra { Id = 13, PasapalabraId = 1, Letra = 'M', Pregunta = "Empieza por M:  País de África ", Respuesta = "Marruecos" },
                new PreguntaPasapalabra { Id = 14, PasapalabraId = 1, Letra = 'N', Pregunta = "Empieza por N: País de Europa ", Respuesta = "Noruega" },
                new PreguntaPasapalabra { Id = 15, PasapalabraId = 1, Letra = 'O', Pregunta = "Empieza por O:  País de Asia ", Respuesta = "Omán" },
                new PreguntaPasapalabra { Id = 16, PasapalabraId = 1, Letra = 'P', Pregunta = "Empieza por P: País de Europa ", Respuesta = "Portugal" },
                new PreguntaPasapalabra { Id = 17, PasapalabraId = 1, Letra = 'Q', Pregunta = "Empieza por Q: País de Asia ", Respuesta = "Qatar" },
                new PreguntaPasapalabra { Id = 18, PasapalabraId = 1, Letra = 'R', Pregunta = "Empieza por R: País de Europa", Respuesta = "Rusia" },
                new PreguntaPasapalabra { Id = 19, PasapalabraId = 1, Letra = 'S', Pregunta = "Empieza por S: País de Europa", Respuesta = "Suecia" },
                new PreguntaPasapalabra { Id = 20, PasapalabraId = 1, Letra = 'T', Pregunta = "Empieza por T: País de Asia ", Respuesta = "Tailandia" },
                new PreguntaPasapalabra { Id = 21, PasapalabraId = 1, Letra = 'U', Pregunta = "Empieza por U: País de Europa ", Respuesta = "Ucrania" },
                new PreguntaPasapalabra { Id = 22, PasapalabraId = 1, Letra = 'V', Pregunta = "Empieza por V: País de Asia que", Respuesta = "Vietnam" },
                new PreguntaPasapalabra { Id = 23, PasapalabraId = 1, Letra = 'W', Pregunta = "Empieza por W: País de Oceanía", Respuesta = "Wallis y Futuna" },
                new PreguntaPasapalabra { Id = 24, PasapalabraId = 1, Letra = 'X', Pregunta = "Empieza por X: Ciudad de China", Respuesta = "Xi'an" },
                new PreguntaPasapalabra { Id = 25, PasapalabraId = 1, Letra = 'Y', Pregunta = "Empieza por Y: País de Asia ", Respuesta = "Yemen" },
                new PreguntaPasapalabra { Id = 26, PasapalabraId = 1, Letra = 'Z', Pregunta = "Empieza por Z: País de África", Respuesta = "Zambia" },

                new PreguntaPasapalabra { Id = 27, PasapalabraId = 2, Letra = 'A', Pregunta = "Empieza por A: Nombre de un animal volador conocido por su aguda visión", Respuesta = "Águila" },
                new PreguntaPasapalabra { Id = 28, PasapalabraId = 2, Letra = 'B', Pregunta = "Empieza por B: Nombre de una fruta amarilla y curvada, popular en todo el mundo", Respuesta = "Banana" },
                new PreguntaPasapalabra { Id = 29, PasapalabraId = 2, Letra = 'C', Pregunta = "Empieza por C: Nombre de un color primario, mezcla de azul y verde", Respuesta = "Cian" },
                new PreguntaPasapalabra { Id = 30, PasapalabraId = 2, Letra = 'D', Pregunta = "Empieza por D: Nombre de un dinosaurio herbívoro con un cuello muy largo", Respuesta = "Diplodocus" },
                new PreguntaPasapalabra { Id = 31, PasapalabraId = 2, Letra = 'E', Pregunta = "Empieza por E: Nombre del continente donde se encuentra España", Respuesta = "Europa" },
                new PreguntaPasapalabra { Id = 32, PasapalabraId = 2, Letra = 'F', Pregunta = "Empieza por F: Nombre de un instrumento musical de viento muy utilizado en la música andina", Respuesta = "Flauta" },
                new PreguntaPasapalabra { Id = 33, PasapalabraId = 2, Letra = 'G', Pregunta = "Empieza por G: Nombre de un deporte que se juega en un campo con 18 hoyos", Respuesta = "Golf" },
                new PreguntaPasapalabra { Id = 34, PasapalabraId = 2, Letra = 'H', Pregunta = "Empieza por H: Nombre del tercer planeta del sistema solar en algunas lenguas", Respuesta = "Helio" },
                new PreguntaPasapalabra { Id = 35, PasapalabraId = 2, Letra = 'I', Pregunta = "Empieza por I: Nombre de un país europeo famoso por su comida y su forma de bota", Respuesta = "Italia" },
                new PreguntaPasapalabra { Id = 36, PasapalabraId = 2, Letra = 'J', Pregunta = "Empieza por J: Nombre del séptimo mes del año", Respuesta = "Julio" },
                new PreguntaPasapalabra { Id = 37, PasapalabraId = 2, Letra = 'K', Pregunta = "Empieza por K: Nombre de un arte marcial japonés", Respuesta = "Karate" },
                new PreguntaPasapalabra { Id = 38, PasapalabraId = 2, Letra = 'L', Pregunta = "Empieza por L: Nombre de un instrumento de cuerda similar a una guitarra pequeña", Respuesta = "Laúd" },
                new PreguntaPasapalabra { Id = 39, PasapalabraId = 2, Letra = 'M', Pregunta = "Empieza por M: Nombre de un mar ubicado entre Europa, Asia y África", Respuesta = "Mediterráneo" },
                new PreguntaPasapalabra { Id = 40, PasapalabraId = 2, Letra = 'N', Pregunta = "Empieza por N: Nombre de un fenómeno meteorológico blanco y frío que cae del cielo", Respuesta = "Nieve" },
                new PreguntaPasapalabra { Id = 41, PasapalabraId = 2, Letra = 'O', Pregunta = "Empieza por O: Nombre de un mamífero marino grande y blanco y negro", Respuesta = "Orca" },
                new PreguntaPasapalabra { Id = 42, PasapalabraId = 2, Letra = 'P', Pregunta = "Empieza por P: Nombre de un país europeo conocido por sus vinos y cuya capital es Lisboa", Respuesta = "Portugal" },
                new PreguntaPasapalabra { Id = 43, PasapalabraId = 2, Letra = 'Q', Pregunta = "Empieza por Q: Nombre de un famoso caricaturista argentino creador de Mafalda", Respuesta = "Quino" },
                new PreguntaPasapalabra { Id = 44, PasapalabraId = 2, Letra = 'R', Pregunta = "Empieza por R: Nombre de una figura geométrica de cuatro lados con ángulos rectos", Respuesta = "Rectángulo" },
                new PreguntaPasapalabra { Id = 45, PasapalabraId = 2, Letra = 'S', Pregunta = "Empieza por S: Nombre de una ciudad española famosa por su catedral y su feria de abril", Respuesta = "Sevilla" },
                new PreguntaPasapalabra { Id = 46, PasapalabraId = 2, Letra = 'T', Pregunta = "Empieza por T: Nombre de un país euroasiático que tiene a Estambul como una de sus ciudades", Respuesta = "Turquía" },
                new PreguntaPasapalabra { Id = 47, PasapalabraId = 2, Letra = 'U', Pregunta = "Empieza por U: Nombre del séptimo planeta del sistema solar", Respuesta = "Urano" },
                new PreguntaPasapalabra { Id = 48, PasapalabraId = 2, Letra = 'V', Pregunta = "Empieza por V: Nombre de un instrumento musical de cuerda, similar al violonchelo pero más pequeño", Respuesta = "Violín" },
                new PreguntaPasapalabra { Id = 49, PasapalabraId = 2, Letra = 'W', Pregunta = "Empieza por W: Nombre de un famoso parque de atracciones en Florida", Respuesta = "Walt Disney World" },
                new PreguntaPasapalabra { Id = 50, PasapalabraId = 2, Letra = 'X', Pregunta = "Empieza por X: Nombre de un instrumento de percusión con placas de madera", Respuesta = "Xilófono" },
                new PreguntaPasapalabra { Id = 51, PasapalabraId = 2, Letra = 'Y', Pregunta = "Empieza por Y: Nombre de un río muy largo en China", Respuesta = "Yangtsé" },
                new PreguntaPasapalabra { Id = 52, PasapalabraId = 2, Letra = 'Z', Pregunta = "Empieza por Z: Nombre de un mamífero con rayas blancas y negras", Respuesta = "Zebra" },

                new PreguntaPasapalabra { Id = 53, PasapalabraId = 3, Letra = 'A', Pregunta = "Empieza por A: Nombre de un famoso científico que desarrolló la teoría de la relatividad", Respuesta = "Einstein" },
                new PreguntaPasapalabra { Id = 54, PasapalabraId = 3, Letra = 'B', Pregunta = "Empieza por B: Nombre de una danza tradicional argentina y uruguaya", Respuesta = "Bailongo" },
                new PreguntaPasapalabra { Id = 55, PasapalabraId = 3, Letra = 'C', Pregunta = "Empieza por C: Nombre del inventor del teléfono", Respuesta = "Bell" },
                new PreguntaPasapalabra { Id = 56, PasapalabraId = 3, Letra = 'D', Pregunta = "Empieza por D: Nombre del pintor surrealista español conocido por sus excéntricas obras", Respuesta = "Dalí" },
                new PreguntaPasapalabra { Id = 57, PasapalabraId = 3, Letra = 'E', Pregunta = "Empieza por E: Nombre del mayor océano del mundo", Respuesta = "Pacífico" },
                new PreguntaPasapalabra { Id = 58, PasapalabraId = 3, Letra = 'F', Pregunta = "Empieza por F: Nombre del autor del libro 'El principito'", Respuesta = "Saint-Exupéry" },
                new PreguntaPasapalabra { Id = 59, PasapalabraId = 3, Letra = 'G', Pregunta = "Empieza por G: Nombre del metal más ligero", Respuesta = "Litio" },
                new PreguntaPasapalabra { Id = 60, PasapalabraId = 3, Letra = 'H', Pregunta = "Empieza por H: Nombre de la isla donde se encuentra la estatua del Cristo Redentor", Respuesta = "Corcovado" },
                new PreguntaPasapalabra { Id = 61, PasapalabraId = 3, Letra = 'I', Pregunta = "Empieza por I: Nombre de un famoso arquitecto español conocido por su obra 'La Sagrada Familia'", Respuesta = "Gaudí" },
                new PreguntaPasapalabra { Id = 62, PasapalabraId = 3, Letra = 'J', Pregunta = "Empieza por J: Nombre de un famoso tenista suizo", Respuesta = "Federer" },
                new PreguntaPasapalabra { Id = 63, PasapalabraId = 3, Letra = 'K', Pregunta = "Empieza por K: Nombre del presidente de Estados Unidos asesinado en 1963", Respuesta = "Kennedy" },
                new PreguntaPasapalabra { Id = 64, PasapalabraId = 3, Letra = 'L', Pregunta = "Empieza por L: Nombre del mayor lago de agua dulce en África", Respuesta = "Victoria" },
                new PreguntaPasapalabra { Id = 65, PasapalabraId = 3, Letra = 'M', Pregunta = "Empieza por M: Nombre de una famosa cadena de montañas en Sudamérica", Respuesta = "Andes" },
                new PreguntaPasapalabra { Id = 66, PasapalabraId = 3, Letra = 'N', Pregunta = "Empieza por N: Nombre del autor de la novela 'Moby-Dick'", Respuesta = "Melville" },
                new PreguntaPasapalabra { Id = 67, PasapalabraId = 3, Letra = 'O', Pregunta = "Empieza por O: Nombre del único mamífero que puede volar", Respuesta = "Murciélago" },
                new PreguntaPasapalabra { Id = 68, PasapalabraId = 3, Letra = 'P', Pregunta = "Empieza por P: Nombre de la ciudad italiana famosa por su torre inclinada", Respuesta = "Pisa" },
                new PreguntaPasapalabra { Id = 69, PasapalabraId = 3, Letra = 'Q', Pregunta = "Empieza por Q: Nombre del ave nacional de Guatemala", Respuesta = "Quetzal" },
                new PreguntaPasapalabra { Id = 70, PasapalabraId = 3, Letra = 'R', Pregunta = "Empieza por R: Nombre del mayor desierto cálido del mundo", Respuesta = "Sahara" },
                new PreguntaPasapalabra { Id = 71, PasapalabraId = 3, Letra = 'S', Pregunta = "Empieza por S: Nombre del satélite natural de la Tierra", Respuesta = "Luna" },
                new PreguntaPasapalabra { Id = 72, PasapalabraId = 3, Letra = 'T', Pregunta = "Empieza por T: Nombre del lugar donde se realiza el festival de la flor de cerezos", Respuesta = "Japón" },
                new PreguntaPasapalabra { Id = 73, PasapalabraId = 3, Letra = 'U', Pregunta = "Empieza por U: Nombre del país conocido por el Machu Picchu", Respuesta = "Perú" },
                new PreguntaPasapalabra { Id = 74, PasapalabraId = 3, Letra = 'V', Pregunta = "Empieza por V: Nombre del pintor que cortó su propia oreja", Respuesta = "Van Gogh" },
                new PreguntaPasapalabra { Id = 75, PasapalabraId = 3, Letra = 'W', Pregunta = "Empieza por W: Nombre del lugar donde se encuentra la Casa Blanca", Respuesta = "Washington, D.C." },
                new PreguntaPasapalabra { Id = 76, PasapalabraId = 3, Letra = 'X', Pregunta = "Empieza por X: Nombre de la técnica de imagen médica que usa radiación", Respuesta = "Rayos X" },
                new PreguntaPasapalabra { Id = 77, PasapalabraId = 3, Letra = 'Y', Pregunta = "Empieza por Y: Nombre de la flor nacional de Japón", Respuesta = "Crisantemo" },
                new PreguntaPasapalabra { Id = 78, PasapalabraId = 3, Letra = 'Z', Pregunta = "Empieza por Z: Nombre de un mineral precioso de color azul", Respuesta = "Zafiro" },

                new PreguntaPasapalabra { Id = 79, PasapalabraId = 4, Letra = 'A', Pregunta = "Empieza por A: An animal that can fly and is known for its colorful feathers", Respuesta = "Parrot" },
                new PreguntaPasapalabra { Id = 80, PasapalabraId = 4, Letra = 'B', Pregunta = "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", Respuesta = "Hippo" },
                new PreguntaPasapalabra { Id = 81, PasapalabraId = 4, Letra = 'C', Pregunta = "Empieza por C: A round, orange vegetable often used in soups and pies", Respuesta = "Carrot" },
                new PreguntaPasapalabra { Id = 82, PasapalabraId = 4, Letra = 'D', Pregunta = "Empieza por D: The opposite of 'night'", Respuesta = "Day" },
                new PreguntaPasapalabra { Id = 83, PasapalabraId = 4, Letra = 'E', Pregunta = "Empieza por E: The planet we live on", Respuesta = "Earth" },
                new PreguntaPasapalabra { Id = 84, PasapalabraId = 4, Letra = 'F', Pregunta = "Empieza por F: What bird is known for its pink feathers and long legs?", Respuesta = "Flamingo" },
                new PreguntaPasapalabra { Id = 85, PasapalabraId = 4, Letra = 'G', Pregunta = "Empieza por G: A color made by mixing blue and yellow", Respuesta = "Green" },
                new PreguntaPasapalabra { Id = 86, PasapalabraId = 4, Letra = 'H', Pregunta = "Empieza por H: A common household pet that purrs", Respuesta = "Cat" },
                new PreguntaPasapalabra { Id = 87, PasapalabraId = 4, Letra = 'I', Pregunta = "Empieza por I: Frozen water", Respuesta = "Ice" },
                new PreguntaPasapalabra { Id = 88, PasapalabraId = 4, Letra = 'J', Pregunta = "Empieza por J: A sweet, red fruit often used to make jam", Respuesta = "Strawberry" },
                new PreguntaPasapalabra { Id = 89, PasapalabraId = 4, Letra = 'K', Pregunta = "Empieza por K: A large bird that cannot fly and is native to Australia", Respuesta = "Koala" },
                new PreguntaPasapalabra { Id = 90, PasapalabraId = 4, Letra = 'L', Pregunta = "Empieza por L: The opposite of 'dark'", Respuesta = "Light" },
                new PreguntaPasapalabra { Id = 91, PasapalabraId = 4, Letra = 'M', Pregunta = "Empieza por M: A small, furry animal that lives in houses and likes cheese", Respuesta = "Mouse" },
                new PreguntaPasapalabra { Id = 92, PasapalabraId = 4, Letra = 'N', Pregunta = "Empieza por N: The time of day when it is dark and people usually sleep", Respuesta = "Night" },
                new PreguntaPasapalabra { Id = 93, PasapalabraId = 4, Letra = 'O', Pregunta = "Empieza por O: A fruit with a tough, spiky shell and sweet, yellow flesh", Respuesta = "Pineapple" },
                new PreguntaPasapalabra { Id = 94, PasapalabraId = 4, Letra = 'P', Pregunta = "Empieza por P: A large mammal known for its trunk", Respuesta = "Elephant" },
                new PreguntaPasapalabra { Id = 95, PasapalabraId = 4, Letra = 'Q', Pregunta = "Empieza por Q: A flying insect known for its painful sting", Respuesta = "Wasp" },
                new PreguntaPasapalabra { Id = 96, PasapalabraId = 4, Letra = 'R', Pregunta = "Empieza por R: A large, round fruit that is often red or green and very juicy", Respuesta = "Watermelon" },
                new PreguntaPasapalabra { Id = 97, PasapalabraId = 4, Letra = 'S', Pregunta = "Empieza por S: The opposite of 'slow'", Respuesta = "Fast" },
                new PreguntaPasapalabra { Id = 98, PasapalabraId = 4, Letra = 'T', Pregunta = "Empieza por T: The opposite of 'short'", Respuesta = "Tall" },
                new PreguntaPasapalabra { Id = 99, PasapalabraId = 4, Letra = 'U', Pregunta = "Empieza por U: The color of a clear sky", Respuesta = "Blue" },
                new PreguntaPasapalabra { Id = 100, PasapalabraId = 4, Letra = 'V', Pregunta = "Empieza por V: A fruit that is often dried and used in cereals", Respuesta = "Raisin" },
                new PreguntaPasapalabra { Id = 101, PasapalabraId = 4, Letra = 'W', Pregunta = "Empieza por W: The opposite of 'dry'", Respuesta = "Wet" },
                new PreguntaPasapalabra { Id = 102, PasapalabraId = 4, Letra = 'X', Pregunta = "Empieza por X: A musical instrument that has wooden bars and is played with mallets", Respuesta = "Xylophone" },
                new PreguntaPasapalabra { Id = 103, PasapalabraId = 4, Letra = 'Y', Pregunta = "Empieza por Y: A color that is the opposite of 'blue'", Respuesta = "Yellow" },
                new PreguntaPasapalabra { Id = 104, PasapalabraId = 4, Letra = 'Z', Pregunta = "Empieza por Z: A wild animal with black and white stripes", Respuesta = "Zebra" },

                new PreguntaPasapalabra { Id = 105, PasapalabraId = 5, Letra = 'A', Pregunta = "Empieza por A: A type of large reptile that lives in water and on land", Respuesta = "Alligator" },
                new PreguntaPasapalabra { Id = 106, PasapalabraId = 5, Letra = 'B', Pregunta = "Empieza por B: A flying insect that produces honey", Respuesta = "Bee" },
                new PreguntaPasapalabra { Id = 107, PasapalabraId = 5, Letra = 'C', Pregunta = "Empieza por C: A round, orange vegetable often used in soups and pies", Respuesta = "Carrot" },
                new PreguntaPasapalabra { Id = 108, PasapalabraId = 5, Letra = 'D', Pregunta = "Empieza por D: A small, round fruit that is often red or black", Respuesta = "Date" },
                new PreguntaPasapalabra { Id = 109, PasapalabraId = 5, Letra = 'E', Pregunta = "Empieza por E: A flying insect known for its painful sting", Respuesta = "Wasp" },
                new PreguntaPasapalabra { Id = 110, PasapalabraId = 5, Letra = 'F', Pregunta = "Empieza por F: An animal similar a cat", Respuesta = "Fox" },
                new PreguntaPasapalabra { Id = 111, PasapalabraId = 5, Letra = 'G', Pregunta = "Empieza por G: A small, round fruit that is often red or black", Respuesta = "Grape" },
                new PreguntaPasapalabra { Id = 112, PasapalabraId = 5, Letra = 'H', Pregunta = "Empieza por H: A tropical fruit with a hard shell and sweet, white flesh", Respuesta = "Honeydew" },
                new PreguntaPasapalabra { Id = 113, PasapalabraId = 5, Letra = 'I', Pregunta = "Empieza por I: A large bird known for its long neck", Respuesta = "Ibis" },
                new PreguntaPasapalabra { Id = 114, PasapalabraId = 5, Letra = 'J', Pregunta = "Empieza por J: A type of large bird that can't fly", Respuesta = "Jabiru" },
                new PreguntaPasapalabra { Id = 115, PasapalabraId = 5, Letra = 'K', Pregunta = "Empieza por K: A marsupial native to Australia known for jumping", Respuesta = "Kangaroo" },
                new PreguntaPasapalabra { Id = 116, PasapalabraId = 5, Letra = 'L', Pregunta = "Empieza por L: A South American mammal known for its wool", Respuesta = "Llama" },
                new PreguntaPasapalabra { Id = 117, PasapalabraId = 5, Letra = 'M', Pregunta = "Empieza por M: A small carnivorous mammal known for its agility and speed", Respuesta = "Mongoose" },
                new PreguntaPasapalabra { Id = 118, PasapalabraId = 5, Letra = 'N', Pregunta = "Empieza por N: A small marsupial native to Australia", Respuesta = "Numbat" },
                new PreguntaPasapalabra { Id = 119, PasapalabraId = 5, Letra = 'O', Pregunta = "Empieza por O: A wild cat native to the Americas", Respuesta = "Ocelot" },
                new PreguntaPasapalabra { Id = 121, PasapalabraId = 5, Letra = 'Q', Pregunta = "Empieza por Q: A small bird often hunted for sport", Respuesta = "Quail" },
                new PreguntaPasapalabra { Id = 123, PasapalabraId = 5, Letra = 'S', Pregunta = "Empieza por S: A slow-moving mammal known for hanging from trees", Respuesta = "Sloth" },
                new PreguntaPasapalabra { Id = 124, PasapalabraId = 5, Letra = 'T', Pregunta = "Empieza por T: A large bird often associated with Thanksgiving", Respuesta = "Turkey" },
                new PreguntaPasapalabra { Id = 125, PasapalabraId = 5, Letra = 'U', Pregunta = "Empieza por U: A wild sheep native to the mountains of Asia", Respuesta = "Urial" },
                new PreguntaPasapalabra { Id = 126, PasapalabraId = 5, Letra = 'V', Pregunta = "Empieza por V: A large bird known for scavenging carrion", Respuesta = "Vulture" },
                new PreguntaPasapalabra { Id = 127, PasapalabraId = 5, Letra = 'W', Pregunta = "Empieza por W: A small marsupial native to Australia", Respuesta = "Wallaby" },
                new PreguntaPasapalabra { Id = 128, PasapalabraId = 5, Letra = 'X', Pregunta = "Empieza por X: A small mammal native to Africa", Respuesta = "Xerus" },
                new PreguntaPasapalabra { Id = 129, PasapalabraId = 5, Letra = 'Y', Pregunta = "Empieza por Y: A large mammal native to the Himalayas", Respuesta = "Yak" },
                new PreguntaPasapalabra { Id = 130, PasapalabraId = 5, Letra = 'Z', Pregunta = "Empieza por Z: A large striped mammal native to Africa", Respuesta = "Zebra" },
                new PreguntaPasapalabra { Id = 131, PasapalabraId = 6, Letra = 'A', Pregunta = "Empieza por A: ¿Qué rama de las matemáticas se encarga del estudio de los números y las operaciones sobre ellos?", Respuesta = "Aritmética" },
                new PreguntaPasapalabra { Id = 132, PasapalabraId = 6, Letra = 'B', Pregunta = "Empieza por B: ¿Cómo se llama la expresión algebraica que consta de dos términos?", Respuesta = "Binomio" },
                new PreguntaPasapalabra { Id = 133, PasapalabraId = 6, Letra = 'C', Pregunta = "Empieza por C: ¿Cuál es la disciplina matemática que estudia el cambio y la acumulación mediante límites, derivadas e integrales?", Respuesta = "Cálculo" },
                new PreguntaPasapalabra { Id = 134, PasapalabraId = 6, Letra = 'D', Pregunta = "Empieza por D: ¿Qué concepto matemático representa la tasa de cambio instantáneo de una función?", Respuesta = "Derivada" },
                new PreguntaPasapalabra { Id = 135, PasapalabraId = 6, Letra = 'E', Pregunta = "Empieza por E: ¿Cómo se llama una igualdad matemática que contiene una o más incógnitas?", Respuesta = "Ecuación" },
                new PreguntaPasapalabra { Id = 136, PasapalabraId = 6, Letra = 'F', Pregunta = "Empieza por F: ¿Qué tipo de relación matemática asigna a cada elemento de un conjunto exactamente un elemento de otro conjunto?", Respuesta = "Función" },
                new PreguntaPasapalabra { Id = 137, PasapalabraId = 6, Letra = 'G', Pregunta = "Empieza por G: ¿Qué rama de las matemáticas se encarga del estudio de las formas, tamaños, y las propiedades del espacio?", Respuesta = "Geometría" },
                new PreguntaPasapalabra { Id = 138, PasapalabraId = 6, Letra = 'H', Pregunta = "Empieza por H: ¿Cómo se llama el lado más largo de un triángulo rectángulo?", Respuesta = "Hipotenusa" },
                new PreguntaPasapalabra { Id = 139, PasapalabraId = 6, Letra = 'I', Pregunta = "Empieza por I: ¿Qué concepto matemático representa el área bajo una curva o la acumulación de una cantidad?", Respuesta = "Integral" },
                new PreguntaPasapalabra { Id = 140, PasapalabraId = 6, Letra = 'J', Pregunta = "Empieza por J: ¿Qué actividad matemática implica manipular números para llegar a un resultado específico?", Respuesta = "Juego de números" },
                new PreguntaPasapalabra { Id = 141, PasapalabraId = 6, Letra = 'K', Pregunta = "Empieza por K: ¿Cómo se denomina la propiedad de un conjunto que indica su tamaño o cantidad de elementos?", Respuesta = "Kardinalidad" },
                new PreguntaPasapalabra { Id = 142, PasapalabraId = 6, Letra = 'L', Pregunta = "Empieza por L: ¿Qué función matemática representa el exponente al que se debe elevar una base para obtener un número determinado?", Respuesta = "Logaritmo" },
                new PreguntaPasapalabra { Id = 143, PasapalabraId = 6, Letra = 'M', Pregunta = "Empieza por M: ¿Cómo se llama una estructura matemática bidimensional que consta de filas y columnas de números?", Respuesta = "Matriz" },
                new PreguntaPasapalabra { Id = 144, PasapalabraId = 6, Letra = 'N', Pregunta = "Empieza por N: ¿Qué término se utiliza para representar un concepto abstracto que denota cantidad o posición?", Respuesta = "Número" },
                new PreguntaPasapalabra { Id = 145, PasapalabraId = 6, Letra = 'O', Pregunta = "Empieza por O: ¿Qué término se utiliza para referirse a una acción matemática como sumar, restar, multiplicar o dividir?", Respuesta = "Operación" },
                new PreguntaPasapalabra { Id = 146, PasapalabraId = 6, Letra = 'P', Pregunta = "Empieza por P: ¿Cómo se llama una expresión algebraica que consta de términos sumados o restados que contienen variables elevadas a exponentes enteros?", Respuesta = "Polinomio" },
                new PreguntaPasapalabra { Id = 147, PasapalabraId = 6, Letra = 'Q', Pregunta = "Empieza por Q: ¿Qué término se utiliza para el resultado de una división?", Respuesta = "Quociente" },
                new PreguntaPasapalabra { Id = 148, PasapalabraId = 6, Letra = 'R', Pregunta = "Empieza por R: ¿Qué término se utiliza para indicar un valor que, cuando se eleva a un determinado exponente, produce un número determinado?", Respuesta = "Raíz" },
                new PreguntaPasapalabra { Id = 150, PasapalabraId = 6, Letra = 'S', Pregunta = "Empieza por S: ¿Qué operación matemática se utiliza para combinar dos o más cantidades?", Respuesta = "Suma" },
                new PreguntaPasapalabra { Id = 151, PasapalabraId = 6, Letra = 'T', Pregunta = "Empieza por T: ¿Qué función trigonométrica representa la razón entre el lado opuesto y el lado adyacente de un ángulo en un triángulo rectángulo?", Respuesta = "Tangente" },
                new PreguntaPasapalabra { Id = 152, PasapalabraId = 6, Letra = 'U', Pregunta = "Empieza por U: ¿Qué término se utiliza para denotar una cantidad específica utilizada como estándar de medida?", Respuesta = "Unidad" },
                new PreguntaPasapalabra { Id = 153, PasapalabraId = 6, Letra = 'V', Pregunta = "Empieza por V: ¿Cómo se llama una cantidad matemática que tiene magnitud y dirección?", Respuesta = "Vector" },
                new PreguntaPasapalabra { Id = 154, PasapalabraId = 6, Letra = 'W', Pregunta = "Empieza por W: ¿Qué concepto matemático se utiliza en el álgebra lineal para determinar la independencia lineal de un conjunto de funciones?", Respuesta = "Wronskiano" },
                new PreguntaPasapalabra { Id = 155, PasapalabraId = 6, Letra = 'X', Pregunta = "Empieza por X: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje x?", Respuesta = "X-intercepto" },
                new PreguntaPasapalabra { Id = 156, PasapalabraId = 6, Letra = 'Y', Pregunta = "Empieza por Y: ¿Qué término se utiliza para denotar el punto donde una gráfica intersecta el eje y?", Respuesta = "Y-intercepto" },
                new PreguntaPasapalabra { Id = 157, PasapalabraId = 6, Letra = 'Z', Pregunta = "Empieza por Z: En ingles, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", Respuesta = "Zero (cero)" }



        );



            // Relación entre Usuario y Avatar
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Avatar)
                .WithMany(a => a.Usuarios)
                .HasForeignKey(u => u.AvatarId)
                .IsRequired();

            // Relación entre Curso y Asignatura
            modelBuilder.Entity<Curso>()
                .HasMany(c => c.Juegos)
                .WithOne(a => a.Curso)
                .HasForeignKey(a => a.IdCurso)
                .IsRequired();

            // Relación entre Asignatura y AsignaturaJuego
            modelBuilder.Entity<Asignatura>()
                .HasMany(a => a.Juegos)
                .WithOne(aj => aj.Asignatura)
                .HasForeignKey(aj => aj.IdAsignatura)
                .IsRequired();

            // Relación entre TipoJuego y AsignaturaJuego
            modelBuilder.Entity<TipoJuego>()
                .HasMany(tj => tj.Juegos)
                .WithOne(aj => aj.TipoJuego)
                .HasForeignKey(aj => aj.IdTipoJuego)
                .IsRequired();

            // Relación entre TipoJuego y AsignaturaJuego
            // modelBuilder.Entity<AsignaturaJuego>()
            //     .HasOne(aj => aj.TipoJuego)
            //     .WithMany(tj => tj.AsignaturaJuegos)
            //     .HasForeignKey(aj => aj.IdTipoJuego)
            //     .IsRequired();

            // Relación entre AsignaturaJuego y Juego
            modelBuilder.Entity<Juego>()
                .HasOne(j => j.TipoJuego)
                .WithMany(aj => aj.Juegos)
                .HasForeignKey(j => j.IdTipoJuego)
                .IsRequired();

            // Relación entre Juego y Pasapalabra
            modelBuilder.Entity<Juego>()
                .HasOne(j => j.Pasapalabra)
                .WithOne(p => p.Juego)
                .HasForeignKey<Pasapalabra>(p => p.IdJuego)
                .IsRequired();



            // Relación entre Pasapalabra y PreguntaPasapalabra
            modelBuilder.Entity<Pasapalabra>()
                .HasMany(p => p.PreguntaPasapalabras)
                .WithOne(pp => pp.Pasapalabra)
                .HasForeignKey(pp => pp.PasapalabraId)
                .IsRequired();


            //Relaciones de Resultados
            modelBuilder.Entity<Resultados>()
                .HasOne(pp => pp.Juego)
                .WithMany(p => p.Resultados)
                .HasForeignKey(pp => pp.IdJuego)
                .IsRequired();
            modelBuilder.Entity<Resultados>()
                .HasOne(pp => pp.Usuario)
                .WithMany(p => p.Resultados)
                .HasForeignKey(pp => pp.IdUsuario)
                .IsRequired();

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<AsignaturaJuego> AsignaturaJuegos { get; set; }
        public DbSet<TipoJuego> TipoJuegos { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Pasapalabra> Pasapalabras { get; set; }
        public DbSet<PreguntaPasapalabra> PreguntaPasapalabras { get; set; }
        public DbSet<Resultados> resultados { get; set; }


    }
}