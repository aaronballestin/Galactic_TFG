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
                new Juego { Id = 8, IdCurso = 1, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 2", Codigo = "XXXXXX" },
                new Juego { Id = 9, IdCurso = 1, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 10, IdCurso = 1, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" },

                new Juego { Id = 11, IdCurso = 2, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Geografía Basica", Codigo = "XXXXXX" },
                new Juego { Id = 12, IdCurso = 2, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 1", Codigo = "XXXXXX" },
                new Juego { Id = 13, IdCurso = 2, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 2", Codigo = "XXXXXX" },
                new Juego { Id = 14, IdCurso = 2, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Basic - 1", Codigo = "XXXXXX" },
                new Juego { Id = 15, IdCurso = 2, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Animals - 1", Codigo = "XXXXXX" },
                new Juego { Id = 16, IdCurso = 2, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Matematicas - General", Codigo = "XXXXXX" },
                new Juego { Id = 17, IdCurso = 2, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 18, IdCurso = 2, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 2", Codigo = "XXXXXX" },
                new Juego { Id = 19, IdCurso = 2, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 20, IdCurso = 2, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" },
                
                new Juego { Id = 21, IdCurso = 3, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Geografía Basica", Codigo = "XXXXXX" },
                new Juego { Id = 22, IdCurso = 3, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 1", Codigo = "XXXXXX" },
                new Juego { Id = 23, IdCurso = 3, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 2", Codigo = "XXXXXX" },
                new Juego { Id = 24, IdCurso = 3, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Basic - 1", Codigo = "XXXXXX" },
                new Juego { Id = 25, IdCurso = 3, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Animals - 1", Codigo = "XXXXXX" },
                new Juego { Id = 26, IdCurso = 3, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Matematicas - General", Codigo = "XXXXXX" },
                new Juego { Id = 27, IdCurso = 3, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 28, IdCurso = 3, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 2", Codigo = "XXXXXX" },
                new Juego { Id = 29, IdCurso = 3, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 30, IdCurso = 3, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" },

                new Juego { Id = 31, IdCurso = 4, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Geografía Basica", Codigo = "XXXXXX" },
                new Juego { Id = 32, IdCurso = 4, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 1", Codigo = "XXXXXX" },
                new Juego { Id = 33, IdCurso = 4, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 2", Codigo = "XXXXXX" },
                new Juego { Id = 34, IdCurso = 4, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Basic - 1", Codigo = "XXXXXX" },
                new Juego { Id = 35, IdCurso = 4, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Animals - 1", Codigo = "XXXXXX" },
                new Juego { Id = 36, IdCurso = 4, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Matematicas - General", Codigo = "XXXXXX" },
                new Juego { Id = 37, IdCurso = 4, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 38, IdCurso = 4, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 2", Codigo = "XXXXXX" },
                new Juego { Id = 39, IdCurso = 4, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 40, IdCurso = 4, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" },

                new Juego { Id = 41, IdCurso = 5, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Geografía Basica", Codigo = "XXXXXX" },
                new Juego { Id = 42, IdCurso = 5, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 1", Codigo = "XXXXXX" },
                new Juego { Id = 43, IdCurso = 5, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 2", Codigo = "XXXXXX" },
                new Juego { Id = 44, IdCurso = 5, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Basic - 1", Codigo = "XXXXXX" },
                new Juego { Id = 45, IdCurso = 5, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Animals - 1", Codigo = "XXXXXX" },
                new Juego { Id = 46, IdCurso = 5, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Matematicas - General", Codigo = "XXXXXX" },
                new Juego { Id = 47, IdCurso = 5, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 48, IdCurso = 5, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 2", Codigo = "XXXXXX" },
                new Juego { Id = 49, IdCurso = 5, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 50, IdCurso = 5, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" },

                new Juego { Id = 51, IdCurso = 6, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Geografía Basica", Codigo = "XXXXXX" },
                new Juego { Id = 52, IdCurso = 6, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 1", Codigo = "XXXXXX" },
                new Juego { Id = 53, IdCurso = 6, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Cultura General - 2", Codigo = "XXXXXX" },
                new Juego { Id = 54, IdCurso = 6, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Basic - 1", Codigo = "XXXXXX" },
                new Juego { Id = 55, IdCurso = 6, IdAsignatura = 5, IdTipoJuego = 1, TemaJuego = "Ingles Animals - 1", Codigo = "XXXXXX" },
                new Juego { Id = 56, IdCurso = 6, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Matematicas - General", Codigo = "XXXXXX" },
                new Juego { Id = 57, IdCurso = 6, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 1", Codigo = "XXXXXX" },
                new Juego { Id = 58, IdCurso = 6, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Lengua - 2", Codigo = "XXXXXX" },
                new Juego { Id = 59, IdCurso = 6, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Plastica", Codigo = "XXXXXX" },
                new Juego { Id = 60, IdCurso = 6, IdAsignatura = 4, IdTipoJuego = 1, TemaJuego = "Musica", Codigo = "XXXXXX" }


            );

            modelBuilder.Entity<Resultados>().HasData(
                new Resultados { Id = 1, IdJuego = 1, IdUsuario = 1, Completado = 'Y' }
            );

            modelBuilder.Entity<Pasapalabra>().HasData(
                new Pasapalabra { Id = 1, Name = "Geografía", IdJuego = 1 },
                new Pasapalabra { Id = 2, Name = "Conocimientos del medio", IdJuego = 2 },
                new Pasapalabra { Id = 3, Name = "Conocimientos del medio", IdJuego = 3 },
                new Pasapalabra { Id = 4, Name = "Inglés Basic", IdJuego = 4 },
                new Pasapalabra { Id = 5, Name = "Ingles Animals", IdJuego = 5 },
                new Pasapalabra { Id = 6, Name = "Matemáticas - 1", IdJuego = 6 },
                new Pasapalabra { Id = 7, Name = "Lengua - 1", IdJuego = 7 },
                new Pasapalabra { Id = 8, Name = "Lengua - 2", IdJuego = 8 },
                new Pasapalabra { Id = 9, Name = "Plástica", IdJuego = 9 },
                new Pasapalabra { Id = 10, Name = "Musica", IdJuego = 10 },
                
                new Pasapalabra { Id = 11, Name = "Geografía", IdJuego = 11 },
                new Pasapalabra { Id = 12, Name = "Nombres de otras cosas pasapalabra", IdJuego = 12 },
                new Pasapalabra { Id = 13, Name = "Nombres de otras cosas pasapalabra", IdJuego = 13 },
                new Pasapalabra { Id = 14, Name = "Nombres de otras cosas pasapalabra", IdJuego = 14 },
                new Pasapalabra { Id = 15, Name = "Nombres de otras cosas pasapalabra", IdJuego = 15 },
                new Pasapalabra { Id = 16, Name = "Nombres de otras cosas pasapalabra", IdJuego = 16 },
                new Pasapalabra { Id = 17, Name = "Nombres de otras cosas pasapalabra", IdJuego = 17 },
                new Pasapalabra { Id = 18, Name = "Nombres de otras cosas pasapalabra", IdJuego = 18 },
                new Pasapalabra { Id = 19, Name = "Nombres de otras cosas pasapalabra", IdJuego = 19 },
                new Pasapalabra { Id = 20, Name = "Nombres de otras cosas pasapalabra", IdJuego = 20 },
                
            
                new Pasapalabra { Id = 21, Name = "Geografía", IdJuego = 21 },
                new Pasapalabra { Id = 22, Name = "Nombres de otras cosas pasapalabra", IdJuego = 22 },
                new Pasapalabra { Id = 23, Name = "Nombres de otras cosas pasapalabra", IdJuego = 23 },
                new Pasapalabra { Id = 24, Name = "Nombres de otras cosas pasapalabra", IdJuego = 24 },
                new Pasapalabra { Id = 25, Name = "Nombres de otras cosas pasapalabra", IdJuego = 25 },
                new Pasapalabra { Id = 26, Name = "Nombres de otras cosas pasapalabra", IdJuego = 26 },
                new Pasapalabra { Id = 27, Name = "Nombres de otras cosas pasapalabra", IdJuego = 27 },
                new Pasapalabra { Id = 28, Name = "Nombres de otras cosas pasapalabra", IdJuego = 28 },
                new Pasapalabra { Id = 29, Name = "Nombres de otras cosas pasapalabra", IdJuego = 29 },
                new Pasapalabra { Id = 30, Name = "Nombres de otras cosas pasapalabra", IdJuego = 30 },
                
                new Pasapalabra { Id = 31, Name = "Geografía", IdJuego = 31 },
                new Pasapalabra { Id = 32, Name = "Nombres de otras cosas pasapalabra", IdJuego = 32 },
                new Pasapalabra { Id = 33, Name = "Nombres de otras cosas pasapalabra", IdJuego = 33 },
                new Pasapalabra { Id = 34, Name = "Nombres de otras cosas pasapalabra", IdJuego = 34 },
                new Pasapalabra { Id = 35, Name = "Nombres de otras cosas pasapalabra", IdJuego = 35 },
                new Pasapalabra { Id = 36, Name = "Nombres de otras cosas pasapalabra", IdJuego = 36 },
                new Pasapalabra { Id = 37, Name = "Nombres de otras cosas pasapalabra", IdJuego = 37 },
                new Pasapalabra { Id = 38, Name = "Nombres de otras cosas pasapalabra", IdJuego = 38 },
                new Pasapalabra { Id = 39, Name = "Nombres de otras cosas pasapalabra", IdJuego = 39 },
                new Pasapalabra { Id = 40, Name = "Nombres de otras cosas pasapalabra", IdJuego = 40 },
                
                new Pasapalabra { Id = 41, Name = "Geografía", IdJuego = 41 },
                new Pasapalabra { Id = 42, Name = "Nombres de otras cosas pasapalabra", IdJuego = 42 },
                new Pasapalabra { Id = 43, Name = "Nombres de otras cosas pasapalabra", IdJuego = 43 },
                new Pasapalabra { Id = 44, Name = "Nombres de otras cosas pasapalabra", IdJuego = 44 },
                new Pasapalabra { Id = 45, Name = "Nombres de otras cosas pasapalabra", IdJuego = 45 },
                new Pasapalabra { Id = 46, Name = "Nombres de otras cosas pasapalabra", IdJuego = 46 },
                new Pasapalabra { Id = 47, Name = "Nombres de otras cosas pasapalabra", IdJuego = 47 },
                new Pasapalabra { Id = 48, Name = "Nombres de otras cosas pasapalabra", IdJuego = 48 },
                new Pasapalabra { Id = 49, Name = "Nombres de otras cosas pasapalabra", IdJuego = 49 },
                new Pasapalabra { Id = 50, Name = "Nombres de otras cosas pasapalabra", IdJuego = 50 },


                new Pasapalabra { Id = 51, Name = "Geografía", IdJuego = 51 },
                new Pasapalabra { Id = 52, Name = "Nombres de otras cosas pasapalabra", IdJuego = 52 },
                new Pasapalabra { Id = 53, Name = "Nombres de otras cosas pasapalabra", IdJuego = 53 },
                new Pasapalabra { Id = 54, Name = "Nombres de otras cosas pasapalabra", IdJuego = 54 },
                new Pasapalabra { Id = 55, Name = "Nombres de otras cosas pasapalabra", IdJuego = 55 },
                new Pasapalabra { Id = 56, Name = "Nombres de otras cosas pasapalabra", IdJuego = 56 },
                new Pasapalabra { Id = 57, Name = "Nombres de otras cosas pasapalabra", IdJuego = 57 },
                new Pasapalabra { Id = 58, Name = "Nombres de otras cosas pasapalabra", IdJuego = 58 },
                new Pasapalabra { Id = 59, Name = "Nombres de otras cosas pasapalabra", IdJuego = 59 },
                new Pasapalabra { Id = 60, Name = "Nombres de otras cosas pasapalabra", IdJuego = 60 }
            );

            modelBuilder.Entity<PreguntaPasapalabra>().HasData(
                new PreguntaPasapalabra { Id = 1, PasapalabraId = 1, Letra = 'A', Pregunta = "Empieza por A: Continente ubicado al este de Europa y al norte de Australia", Respuesta = "Asia" },
                new PreguntaPasapalabra { Id = 2, PasapalabraId = 1, Letra = 'B', Pregunta = "Empieza por B: Capital de Alemania, famosa por su Muro", Respuesta = "Berlín" },
                new PreguntaPasapalabra { Id = 3, PasapalabraId = 1, Letra = 'C', Pregunta = "Empieza por C: País de América del Sur conocido por su forma alargada y su costa en el Pacífico", Respuesta = "Chile" },
                new PreguntaPasapalabra { Id = 4, PasapalabraId = 1, Letra = 'D', Pregunta = "Empieza por D: País escandinavo de Europa famoso por sus bicicletas y canales en Copenhague", Respuesta = "Dinamarca" },
                new PreguntaPasapalabra { Id = 5, PasapalabraId = 1, Letra = 'E', Pregunta = "Empieza por E: País de África famoso por sus antiguas pirámides y la Esfinge", Respuesta = "Egipto" },
                new PreguntaPasapalabra { Id = 6, PasapalabraId = 1, Letra = 'F', Pregunta = "Empieza por F: País de Europa conocido por su torre Eiffel y su capital París", Respuesta = "Francia" },
                new PreguntaPasapalabra { Id = 7, PasapalabraId = 1, Letra = 'G', Pregunta = "Empieza por G: País de América Central cuyo nombre rima con 'mala'", Respuesta = "Guatemala" },
                new PreguntaPasapalabra { Id = 8, PasapalabraId = 1, Letra = 'H', Pregunta = "Empieza por H: País de América Central famoso por sus ruinas mayas en Copán", Respuesta = "Honduras" },
                new PreguntaPasapalabra { Id = 9, PasapalabraId = 1, Letra = 'I', Pregunta = "Empieza por I: País europeo conocido por su forma de bota", Respuesta = "Italia" },
                new PreguntaPasapalabra { Id = 10, PasapalabraId = 1, Letra = 'J', Pregunta = "Empieza por J: País insular de Asia conocido por su tecnología avanzada y su cultura del anime", Respuesta = "Japón" },
                new PreguntaPasapalabra { Id = 11, PasapalabraId = 1, Letra = 'K', Pregunta = "Empieza por K: País de Asia central cuyo nombre termina en '-stán'", Respuesta = "Kazajistán" },
                new PreguntaPasapalabra { Id = 12, PasapalabraId = 1, Letra = 'L', Pregunta = "Empieza por L: País báltico de Europa cuya capital es Vilna", Respuesta = "Lituania" },
                new PreguntaPasapalabra { Id = 13, PasapalabraId = 1, Letra = 'M', Pregunta = "Empieza por M: País del norte de África famoso por sus mercados en Marrakech", Respuesta = "Marruecos" },
                new PreguntaPasapalabra { Id = 14, PasapalabraId = 1, Letra = 'N', Pregunta = "Empieza por N: País escandinavo de Europa conocido por sus fiordos", Respuesta = "Noruega" },
                new PreguntaPasapalabra { Id = 15, PasapalabraId = 1, Letra = 'O', Pregunta = "Empieza por O: País de Asia famoso por su desierto y su incienso", Respuesta = "Omán" },
                new PreguntaPasapalabra { Id = 16, PasapalabraId = 1, Letra = 'P', Pregunta = "Empieza por P: País europeo conocido por sus vinos de Oporto y su capital Lisboa", Respuesta = "Portugal" },
                new PreguntaPasapalabra { Id = 17, PasapalabraId = 1, Letra = 'Q', Pregunta = "Empieza por Q: País del Golfo Pérsico conocido por su rica reserva de gas natural", Respuesta = "Qatar" },
                new PreguntaPasapalabra { Id = 18, PasapalabraId = 1, Letra = 'R', Pregunta = "Empieza por R: País más grande del mundo, situado en Europa y Asia", Respuesta = "Rusia" },
                new PreguntaPasapalabra { Id = 19, PasapalabraId = 1, Letra = 'S', Pregunta = "Empieza por S: País nórdico de Europa famoso por sus coches Volvo y su capital Estocolmo", Respuesta = "Suecia" },
                new PreguntaPasapalabra { Id = 20, PasapalabraId = 1, Letra = 'T', Pregunta = "Empieza por T: País del sudeste asiático conocido por sus templos y su capital Bangkok", Respuesta = "Tailandia" },
                new PreguntaPasapalabra { Id = 21, PasapalabraId = 1, Letra = 'U', Pregunta = "Empieza por U: País de Europa del Este cuya capital es Kiev", Respuesta = "Ucrania" },
                new PreguntaPasapalabra { Id = 22, PasapalabraId = 1, Letra = 'V', Pregunta = "Empieza por V: País del sudeste asiático conocido por su guerra con Estados Unidos en los años 60 y 70", Respuesta = "Vietnam" },
                new PreguntaPasapalabra { Id = 23, PasapalabraId = 1, Letra = 'W', Pregunta = "Empieza por W: Territorio de Oceanía compuesto por tres islas principales", Respuesta = "Wallis y Futuna" },
                new PreguntaPasapalabra { Id = 24, PasapalabraId = 1, Letra = 'X', Pregunta = "Empieza por X: Ciudad china famosa por sus guerreros de terracota", Respuesta = "Xi'an" },
                new PreguntaPasapalabra { Id = 25, PasapalabraId = 1, Letra = 'Y', Pregunta = "Empieza por Y: País de la península arábiga cuyo capital es Saná", Respuesta = "Yemen" },
                new PreguntaPasapalabra { Id = 26, PasapalabraId = 1, Letra = 'Z', Pregunta = "Empieza por Z: País del sur de África cuya capital es Lusaka", Respuesta = "Zambia" },



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

                new PreguntaPasapalabra { Id = 53, PasapalabraId = 3, Letra = 'A', Pregunta = "Empieza por A: ¿Qué necesitamos beber para mantenernos hidratados?", Respuesta = "Agua" },
                new PreguntaPasapalabra { Id = 54, PasapalabraId = 3, Letra = 'B', Pregunta = "Empieza por B: ¿Cómo se llama la capa de la Tierra donde se concentra la vida?", Respuesta = "Biosfera" },
                new PreguntaPasapalabra { Id = 55, PasapalabraId = 3, Letra = 'C', Pregunta = "Empieza por C: ¿Cuál es la unidad básica de los seres vivos?", Respuesta = "Célula" },
                new PreguntaPasapalabra { Id = 56, PasapalabraId = 3, Letra = 'D', Pregunta = "Empieza por D: ¿Qué tipo de animales gigantes poblaron la Tierra hace millones de años?", Respuesta = "Dinosaurio" },
                new PreguntaPasapalabra { Id = 57, PasapalabraId = 3, Letra = 'E', Pregunta = "Empieza por E: ¿Cómo se llama el conjunto de seres vivos y su entorno físico?", Respuesta = "Ecosistema" },
                new PreguntaPasapalabra { Id = 58, PasapalabraId = 3, Letra = 'F', Pregunta = "Empieza por F: ¿Qué proceso realizan las plantas para obtener energía del sol?", Respuesta = "Fotosíntesis" },
                new PreguntaPasapalabra { Id = 59, PasapalabraId = 3, Letra = 'G', Pregunta = "Empieza por G: ¿Qué fuerza mantiene nuestros pies en el suelo?", Respuesta = "Gravedad" },
                new PreguntaPasapalabra { Id = 60, PasapalabraId = 3, Letra = 'H', Pregunta = "Empieza por H: ¿Qué parte del cuerpo humano nos permite movernos y mantenernos erguidos?", Respuesta = "Hueso" },
                new PreguntaPasapalabra { Id = 61, PasapalabraId = 3, Letra = 'I', Pregunta = "Empieza por I: ¿Qué objeto atrae a otros objetos de metal?", Respuesta = "Imán" },
                new PreguntaPasapalabra { Id = 62, PasapalabraId = 3, Letra = 'J', Pregunta = "Empieza por J: ¿Qué animal tiene un cuello largo y manchas en su piel?", Respuesta = "Jirafa" },
                new PreguntaPasapalabra { Id = 63, PasapalabraId = 3, Letra = 'K', Pregunta = "Empieza por K: ¿Qué unidad de medida utilizamos para pesar objetos?", Respuesta = "Kilogramo" },
                new PreguntaPasapalabra { Id = 64, PasapalabraId = 3, Letra = 'L', Pregunta = "Empieza por L: ¿Qué necesitamos para ver las cosas?", Respuesta = "Luz" },
                new PreguntaPasapalabra { Id = 65, PasapalabraId = 3, Letra = 'M', Pregunta = "Empieza por M: ¿Cómo se llaman las partículas más pequeñas de una sustancia?", Respuesta = "Molécula" },
                new PreguntaPasapalabra { Id = 66, PasapalabraId = 3, Letra = 'N', Pregunta = "Empieza por N: ¿Qué necesitan los seres vivos para crecer y mantenerse saludables?", Respuesta = "Nutriente" },
                new PreguntaPasapalabra { Id = 67, PasapalabraId = 3, Letra = 'O', Pregunta = "Empieza por O: ¿Qué gas necesitamos respirar para vivir?", Respuesta = "Oxígeno" },
                new PreguntaPasapalabra { Id = 68, PasapalabraId = 3, Letra = 'P', Pregunta = "Empieza por P: ¿Qué placa de la Tierra se mueve y puede causar terremotos y volcanes?", Respuesta = "Placa" },
                new PreguntaPasapalabra { Id = 69, PasapalabraId = 3, Letra = 'Q', Pregunta = "Empieza por Q: ¿Qué ciencia estudia la composición de las sustancias y sus transformaciones?", Respuesta = "Química" },
                new PreguntaPasapalabra { Id = 70, PasapalabraId = 3, Letra = 'R', Pregunta = "Empieza por R: ¿Qué parte de la planta se encuentra bajo tierra y absorbe agua y nutrientes?", Respuesta = "Raíz" },
                new PreguntaPasapalabra { Id = 71, PasapalabraId = 3, Letra = 'S', Pregunta = "Empieza por S: ¿Cómo se llama el satélite natural de la Tierra?", Respuesta = "Luna" },
                new PreguntaPasapalabra { Id = 72, PasapalabraId = 3, Letra = 'T', Pregunta = "Empieza por T: ¿Qué medida nos indica si hace calor o frío en un lugar?", Respuesta = "Temperatura" },
                new PreguntaPasapalabra { Id = 73, PasapalabraId = 3, Letra = 'U', Pregunta = "Empieza por U: ¿Cuál es el séptimo planeta del sistema solar?", Respuesta = "Urano" },
                new PreguntaPasapalabra { Id = 74, PasapalabraId = 3, Letra = 'V', Pregunta = "Empieza por V: ¿Qué montaña expulsa lava, cenizas y gases?", Respuesta = "Volcán" },
                new PreguntaPasapalabra { Id = 75, PasapalabraId = 3, Letra = 'W', Pregunta = "Empieza por W: ¿Qué unidad de medida utilizamos para medir la potencia de la electricidad?", Respuesta = "Vatios" },
                new PreguntaPasapalabra { Id = 76, PasapalabraId = 3, Letra = 'X', Pregunta = "Empieza por X: ¿Qué tejido en las plantas transporta agua y nutrientes desde las raíces hasta las hojas?", Respuesta = "Xilema" },
                new PreguntaPasapalabra { Id = 77, PasapalabraId = 3, Letra = 'Y', Pregunta = "Empieza por Y: ¿Cómo se llama la parte nutritiva contenida dentro de un huevo?", Respuesta = "Yema" },
                new PreguntaPasapalabra { Id = 78, PasapalabraId = 3, Letra = 'Z', Pregunta = "Empieza por Z: ¿Dónde podemos observar y aprender sobre diferentes especies animales?", Respuesta = "Zoológico" },

                new PreguntaPasapalabra { Id = 79, PasapalabraId = 4, Letra = 'A', Pregunta = "Empieza por A: An animal that can fly and is known for its colorful feathers", Respuesta = "Ara" },
                new PreguntaPasapalabra { Id = 80, PasapalabraId = 4, Letra = 'B', Pregunta = "Empieza por B: A type of large animal that lives in rivers and lakes and can be very dangerous", Respuesta = "Bear" },
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
                new PreguntaPasapalabra { Id = 157, PasapalabraId = 6, Letra = 'Z', Pregunta = "Empieza por Z: En ingles, ¿Cómo se llama el número que representa la ausencia de cantidad o valor?", Respuesta = "Zero (cero)" },

                new PreguntaPasapalabra { Id = 158, PasapalabraId = 7, Letra = 'A', Pregunta = "Empieza por A: ¿Qué elemento gramatical se utiliza para introducir o modificar un sustantivo en una oración?", Respuesta = "Artículo" },
                new PreguntaPasapalabra { Id = 159, PasapalabraId = 7, Letra = 'B', Pregunta = "Empieza por B: ¿Qué tipo de texto relata la vida de una persona escrita por otra?", Respuesta = "Biografía" },
                new PreguntaPasapalabra { Id = 160, PasapalabraId = 7, Letra = 'C', Pregunta = "Empieza por C: ¿Qué palabra se usa para unir frases, palabras o cláusulas en una oración?", Respuesta = "Conjunción" },
                new PreguntaPasapalabra { Id = 161, PasapalabraId = 7, Letra = 'D', Pregunta = "Empieza por D: ¿Cómo se llama la combinación de dos vocales en una misma sílaba?", Respuesta = "Diptongo" },
                new PreguntaPasapalabra { Id = 162, PasapalabraId = 7, Letra = 'E', Pregunta = "Empieza por E: ¿Qué habilidad se desarrolla al escribir cartas, cuentos o poesías?", Respuesta = "Escritura" },
                new PreguntaPasapalabra { Id = 163, PasapalabraId = 7, Letra = 'F', Pregunta = "Empieza por F: ¿Qué representa los sonidos básicos del habla?", Respuesta = "Fonema" },
                new PreguntaPasapalabra { Id = 164, PasapalabraId = 7, Letra = 'G', Pregunta = "Empieza por G: ¿Qué se estudia para comprender la estructura de un idioma?", Respuesta = "Gramática" },
                new PreguntaPasapalabra { Id = 165, PasapalabraId = 7, Letra = 'H', Pregunta = "Empieza por H: ¿Qué palabra significa dos o más palabras que suenan igual pero tienen diferente significado o escritura?", Respuesta = "Homófono" },
                new PreguntaPasapalabra { Id = 166, PasapalabraId = 7, Letra = 'I', Pregunta = "Empieza por I: ¿Cómo se llama a las palabras que expresan emociones o sentimientos y no tienen una función sintáctica definida?", Respuesta = "Interjección" },
                new PreguntaPasapalabra { Id = 167, PasapalabraId = 7, Letra = 'J', Pregunta = "Empieza por J: ¿Qué actividad es recreativa y educativa a la vez, en la que se aplican reglas para divertirse?", Respuesta = "Juego" },
                new PreguntaPasapalabra { Id = 168, PasapalabraId = 7, Letra = 'K', Pregunta = "Empieza por K: ¿Qué lugar suele tener una variedad de productos y periódicos y revistas para su venta?", Respuesta = "Kiosco" },
                new PreguntaPasapalabra { Id = 169, PasapalabraId = 7, Letra = 'L', Pregunta = "Empieza por L: ¿Qué símbolo gráfico representa los sonidos básicos del habla?", Respuesta = "Letra" },
                new PreguntaPasapalabra { Id = 170, PasapalabraId = 7, Letra = 'M', Pregunta = "Empieza por M: ¿Qué unidad mínima de significado tiene un idioma?", Respuesta = "Morfema" },
                new PreguntaPasapalabra { Id = 171, PasapalabraId = 7, Letra = 'N', Pregunta = "Empieza por N: ¿Qué persona cuenta una historia o relato?", Respuesta = "Narrador" },
                new PreguntaPasapalabra { Id = 172, PasapalabraId = 7, Letra = 'O', Pregunta = "Empieza por O: ¿Qué estructura gramatical contiene un sujeto y un predicado y expresa una idea completa?", Respuesta = "Oración" },
                new PreguntaPasapalabra { Id = 173, PasapalabraId = 7, Letra = 'P', Pregunta = "Empieza por P: ¿Cómo se denomina a la unidad básica del lenguaje, que comunica un concepto?", Respuesta = "Palabra" },
                new PreguntaPasapalabra { Id = 174, PasapalabraId = 7, Letra = 'Q', Pregunta = "Empieza por Q: ¿Qué palabra se emplea para describir un juego verbal en el que se repiten los mismos sonidos?", Respuesta = "Querido" },
                new PreguntaPasapalabra { Id = 175, PasapalabraId = 7, Letra = 'R', Pregunta = "Empieza por R: ¿Qué componente del lenguaje se estudia para entender cómo se forman y se pronuncian los sonidos en las palabras?", Respuesta = "Rima" },
                new PreguntaPasapalabra { Id = 176, PasapalabraId = 7, Letra = 'S', Pregunta = "Empieza por S: ¿Qué elemento gramatical se utiliza para conectar ideas o acciones dentro de una oración o un texto?", Respuesta = "Sujeto" },
                new PreguntaPasapalabra { Id = 177, PasapalabraId = 7, Letra = 'T', Pregunta = "Empieza por T: ¿Qué actividad literaria implica la creación y combinación de sonidos para desafiar la pronunciación?", Respuesta = "Trabalenguas" },
                new PreguntaPasapalabra { Id = 178, PasapalabraId = 7, Letra = 'U', Pregunta = "Empieza por U: ¿Qué se utiliza para hacer referencia a un suceso imaginario o inventado que se relata de forma breve y con una enseñanza o moraleja?", Respuesta = "Uso" },
                new PreguntaPasapalabra { Id = 179, PasapalabraId = 7, Letra = 'V', Pregunta = "Empieza por V: ¿Qué se refiere a la variedad y selección de palabras que una persona conoce y utiliza en su comunicación?", Respuesta = "Vocabulario" },
                new PreguntaPasapalabra { Id = 180, PasapalabraId = 7, Letra = 'W', Pregunta = "Empieza por W: ¿Qué tipo de texto se compone de una serie de letras y signos que representan sonidos y que, al combinarse, forman palabras?", Respuesta = "Watusi" },
                new PreguntaPasapalabra { Id = 181, PasapalabraId = 7, Letra = 'X', Pregunta = "Empieza por X: ¿Qué palabra se utiliza para describir un sonido compuesto por la combinación de dos vocales en una misma sílaba?", Respuesta = "Xilófono" },
                new PreguntaPasapalabra { Id = 183, PasapalabraId = 7, Letra = 'Y', Pregunta = "Empieza por Y: ¿Qué figura literaria se produce cuando una palabra o grupo de palabras se repiten al inicio de dos o más versos o frases?", Respuesta = "Yod" },
                new PreguntaPasapalabra { Id = 184, PasapalabraId = 7, Letra = 'Z', Pregunta = "Empieza por Z: ¿Qué componente del lenguaje se estudia para comprender cómo se utilizan las palabras y frases en diferentes situaciones?", Respuesta = "Zona" },

                new PreguntaPasapalabra { Id = 185, PasapalabraId = 8, Letra = 'A', Pregunta = "¿Qué parte de la oración describe o califica al sustantivo?", Respuesta = "Adjetivo" },
                new PreguntaPasapalabra { Id = 186, PasapalabraId = 8, Letra = 'B', Pregunta = "¿Qué tipo de texto relata la vida de una persona escrita por otra?", Respuesta = "Biografía" },
                new PreguntaPasapalabra { Id = 187, PasapalabraId = 8, Letra = 'C', Pregunta = "¿Qué tipo de palabra une dos oraciones o partes de una oración?", Respuesta = "Conjunción" },
                new PreguntaPasapalabra { Id = 188, PasapalabraId = 8, Letra = 'D', Pregunta = "¿Cómo se llama la secuencia de dos vocales que se pronuncian en una sola emisión de voz?", Respuesta = "Diptongo" },
                new PreguntaPasapalabra { Id = 189, PasapalabraId = 8, Letra = 'E', Pregunta = "¿Cómo se llama el conjunto de palabras que expresan una idea completa?", Respuesta = "Enunciado" },
                new PreguntaPasapalabra { Id = 190, PasapalabraId = 8, Letra = 'F', Pregunta = "¿Cómo se le llama a la unidad mínima de sonido en un idioma?", Respuesta = "Fonema" },
                new PreguntaPasapalabra { Id = 191, PasapalabraId = 8, Letra = 'G', Pregunta = "¿Qué rama de la lingüística estudia la estructura de las palabras?", Respuesta = "Gramática" },
                new PreguntaPasapalabra { Id = 192, PasapalabraId = 8, Letra = 'H', Pregunta = "¿Cómo se llama una palabra que suena igual que otra pero se escribe diferente y tiene distinto significado?", Respuesta = "Homófono" },
                new PreguntaPasapalabra { Id = 193, PasapalabraId = 8, Letra = 'I', Pregunta = "¿Cómo se llama una palabra que expresa emoción o sentimiento y no tiene relación gramatical con otras palabras de la oración?", Respuesta = "Interjección" },
                new PreguntaPasapalabra { Id = 194, PasapalabraId = 8, Letra = 'J', Pregunta = "¿Cómo se le llama al lenguaje especializado de un grupo profesional o social?", Respuesta = "Jerga" },
                new PreguntaPasapalabra { Id = 195, PasapalabraId = 8, Letra = 'K', Pregunta = "¿Qué arte marcial tiene su origen en Okinawa, Japón?", Respuesta = "Kárate" },
                new PreguntaPasapalabra { Id = 196, PasapalabraId = 8, Letra = 'L', Pregunta = "¿Cómo se le llama a cada una de las grafías del alfabeto?", Respuesta = "Letra" },
                new PreguntaPasapalabra { Id = 197, PasapalabraId = 8, Letra = 'M', Pregunta = "¿Cómo se llama la unidad mínima de significado en la palabra?", Respuesta = "Morfema" },
                new PreguntaPasapalabra { Id = 198, PasapalabraId = 8, Letra = 'N', Pregunta = "¿Cómo se llama la palabra que designa a personas, animales, cosas o ideas?", Respuesta = "Nombre" },
                new PreguntaPasapalabra { Id = 199, PasapalabraId = 8, Letra = 'O', Pregunta = "¿Cómo se llama una frase que expresa una idea completa con sentido propio?", Respuesta = "Oración" },
                new PreguntaPasapalabra { Id = 200, PasapalabraId = 8, Letra = 'P', Pregunta = "¿Cómo se llama la palabra que sustituye al nombre?", Respuesta = "Pronombre" },
                new PreguntaPasapalabra { Id = 201, PasapalabraId = 8, Letra = 'Q', Pregunta = "¿Qué error gramatical se produce al usar de forma incorrecta la palabra 'que'?", Respuesta = "Queísmo" },
                new PreguntaPasapalabra { Id = 202, PasapalabraId = 8, Letra = 'R', Pregunta = "¿Cómo se le llama a la repetición de sonidos al final de dos o más versos?", Respuesta = "Rima" },
                new PreguntaPasapalabra { Id = 203, PasapalabraId = 8, Letra = 'S', Pregunta = "¿Quién o qué realiza la acción en una oración?", Respuesta = "Sujeto" },
                new PreguntaPasapalabra { Id = 204, PasapalabraId = 8, Letra = 'T', Pregunta = "¿Cómo se llama la forma en que se conjugan los verbos para indicar el momento en que se realiza la acción?", Respuesta = "Tiempo verbal" },
                new PreguntaPasapalabra { Id = 205, PasapalabraId = 8, Letra = 'U', Pregunta = "¿Cómo se llama la manera correcta de emplear el lenguaje según las normas gramaticales?", Respuesta = "Uso" },
                new PreguntaPasapalabra { Id = 206, PasapalabraId = 8, Letra = 'V', Pregunta = "¿Cómo se llama la forma verbal en la que el sujeto recibe la acción del verbo?", Respuesta = "Voz pasiva" },
                new PreguntaPasapalabra { Id = 207, PasapalabraId = 8, Letra = 'W', Pregunta = "¿Qué baile originario de África Central se popularizó en los años 60?", Respuesta = "Watusi" },
                new PreguntaPasapalabra { Id = 208, PasapalabraId = 8, Letra = 'X', Pregunta = "¿Qué técnica de impresión se realiza sobre madera?", Respuesta = "Xilografía" },
                new PreguntaPasapalabra { Id = 209, PasapalabraId = 8, Letra = 'Y', Pregunta = "¿Cómo se le llama a la unión de dos o más ideas o palabras sin relación gramatical?", Respuesta = "Yuxtaposición" },
                new PreguntaPasapalabra { Id = 210, PasapalabraId = 8, Letra = 'Z', Pregunta = "¿Cómo se le llama al uso de un mismo término para dos sentidos diferentes en un enunciado?", Respuesta = "Zeugma" },

                new PreguntaPasapalabra { Id = 211, PasapalabraId = 9, Letra = 'A', Pregunta = "¿Qué tipo de pintura se diluye en agua y se aplica con pincel?", Respuesta = "Acuarela" },
                new PreguntaPasapalabra { Id = 212, PasapalabraId = 9, Letra = 'B', Pregunta = "¿Qué material se utiliza para modelar figuras y vasijas?", Respuesta = "Barro" },
                new PreguntaPasapalabra { Id = 213, PasapalabraId = 9, Letra = 'C', Pregunta = "¿Con qué herramienta se pueden colorear dibujos?", Respuesta = "Crayón" },
                new PreguntaPasapalabra { Id = 214, PasapalabraId = 9, Letra = 'D', Pregunta = "¿Qué actividad implica plasmar ideas en papel?", Respuesta = "Dibujo" },
                new PreguntaPasapalabra { Id = 215, PasapalabraId = 9, Letra = 'E', Pregunta = "¿Qué arte consiste en esculpir figuras en materiales como arcilla o piedra?", Respuesta = "Escultura" },
                new PreguntaPasapalabra { Id = 216, PasapalabraId = 9, Letra = 'F', Pregunta = "¿Cómo se le llama a una representación visual de una forma?", Respuesta = "Figura" },
                new PreguntaPasapalabra { Id = 217, PasapalabraId = 9, Letra = 'G', Pregunta = "¿Qué material se usa para borrar trazos en papel?", Respuesta = "Goma" },
                new PreguntaPasapalabra { Id = 218, PasapalabraId = 9, Letra = 'H', Pregunta = "¿Sobre qué superficie se dibuja o pinta?", Respuesta = "Hoja" },
                new PreguntaPasapalabra { Id = 219, PasapalabraId = 9, Letra = 'I', Pregunta = "¿Cómo se llama una representación visual de algo?", Respuesta = "Imagen" },
                new PreguntaPasapalabra { Id = 220, PasapalabraId = 9, Letra = 'J', Pregunta = "¿Qué se hace con materiales para divertirse y aprender?", Respuesta = "Juego" },
                new PreguntaPasapalabra { Id = 221, PasapalabraId = 9, Letra = 'K', Pregunta = "¿Qué conjunto de herramientas se utiliza para crear arte?", Respuesta = "Kit" },
                new PreguntaPasapalabra { Id = 222, PasapalabraId = 9, Letra = 'L', Pregunta = "¿Qué objeto se usa para colorear o dibujar?", Respuesta = "Lápiz" },
                new PreguntaPasapalabra { Id = 223, PasapalabraId = 9, Letra = 'M', Pregunta = "¿Qué masa se utiliza para modelar figuras?", Respuesta = "Masa" },
                new PreguntaPasapalabra { Id = 224, PasapalabraId = 9, Letra = 'N', Pregunta = "¿Qué se estudia en plástica relacionado con la vida natural?", Respuesta = "Naturaleza" },
                new PreguntaPasapalabra { Id = 225, PasapalabraId = 9, Letra = 'O', Pregunta = "¿Qué tipo de pintura se hace con óleo?", Respuesta = "Óleo" },
                new PreguntaPasapalabra { Id = 226, PasapalabraId = 9, Letra = 'P', Pregunta = "¿Sobre qué se pueden realizar dibujos o manualidades?", Respuesta = "Papel" },
                new PreguntaPasapalabra { Id = 227, PasapalabraId = 9, Letra = 'Q', Pregunta = "¿Qué utensilio se utiliza para calentar y endurecer cerámica?", Respuesta = "Quemador" },
                new PreguntaPasapalabra { Id = 228, PasapalabraId = 9, Letra = 'R', Pregunta = "¿Qué objeto se utiliza para extender pintura de forma uniforme?", Respuesta = "Rodillo" },
                new PreguntaPasapalabra { Id = 229, PasapalabraId = 9, Letra = 'S', Pregunta = "¿Qué se utiliza para estampar diseños en papel?", Respuesta = "Sello" },
                new PreguntaPasapalabra { Id = 230, PasapalabraId = 9, Letra = 'T', Pregunta = "¿Qué tipo de pintura se utiliza en manualidades y en la escuela?", Respuesta = "Tempera" },
                new PreguntaPasapalabra { Id = 231, PasapalabraId = 9, Letra = 'U', Pregunta = "¿Qué se hace con los materiales de arte y manualidades?", Respuesta = "Uso" },
                new PreguntaPasapalabra { Id = 232, PasapalabraId = 9, Letra = 'V', Pregunta = "¿En qué se bebe agua o se mezcla pintura?", Respuesta = "Vaso" },
                new PreguntaPasapalabra { Id = 233, PasapalabraId = 9, Letra = 'W', Pregunta = "¿Qué tipo de cinta adhesiva se utiliza para decorar?", Respuesta = "Washi" },
                new PreguntaPasapalabra { Id = 234, PasapalabraId = 9, Letra = 'X', Pregunta = "¿Qué técnica de impresión se realiza sobre madera?", Respuesta = "Xilografía" },
                new PreguntaPasapalabra { Id = 235, PasapalabraId = 9, Letra = 'Y', Pregunta = "¿Qué material se usa para modelar figuras y realizar moldes?", Respuesta = "Yeso" },
                new PreguntaPasapalabra { Id = 236, PasapalabraId = 9, Letra = 'Z', Pregunta = "¿Qué patrón se forma con líneas que se juntan y separan de forma diagonal?", Respuesta = "Zigzag" },

                new PreguntaPasapalabra { Id = 237, PasapalabraId = 10, Letra = 'A', Pregunta = "¿Qué conjunto de sonidos simultáneos forman la base de la armonía?", Respuesta = "Acorde" },
                new PreguntaPasapalabra { Id = 238, PasapalabraId = 10, Letra = 'B', Pregunta = "¿Qué instrumento de percusión se compone de tambores y platillos?", Respuesta = "Batería" },
                new PreguntaPasapalabra { Id = 239, PasapalabraId = 10, Letra = 'C', Pregunta = "¿Cómo se llama una composición musical con letra?", Respuesta = "Canción" },
                new PreguntaPasapalabra { Id = 240, PasapalabraId = 10, Letra = 'D', Pregunta = "¿Cuál es la primera nota de la escala musical?", Respuesta = "Do" },
                new PreguntaPasapalabra { Id = 241, PasapalabraId = 10, Letra = 'E', Pregunta = "¿Qué serie de notas ordenadas de forma ascendente y descendente forman una escala?", Respuesta = "Escala" },
                new PreguntaPasapalabra { Id = 242, PasapalabraId = 10, Letra = 'F', Pregunta = "¿Qué instrumento de viento se toca soplando por un tubo?", Respuesta = "Flauta" },
                new PreguntaPasapalabra { Id = 243, PasapalabraId = 10, Letra = 'G', Pregunta = "¿Qué instrumento de cuerda se toca frotando las cuerdas con un arco?", Respuesta = "Guitarra" },
                new PreguntaPasapalabra { Id = 244, PasapalabraId = 10, Letra = 'H', Pregunta = "¿Qué tipo de sonido se produce al hacer vibrar una cuerda o columna de aire?", Respuesta = "Harmónico" },
                new PreguntaPasapalabra { Id = 245, PasapalabraId = 10, Letra = 'I', Pregunta = "¿Cómo se llama el objeto utilizado para producir música?", Respuesta = "Instrumento" },
                new PreguntaPasapalabra { Id = 246, PasapalabraId = 10, Letra = 'J', Pregunta = "¿Qué estilo musical se caracteriza por su improvisación y ritmo syncopado?", Respuesta = "Jazz" },
                new PreguntaPasapalabra { Id = 247, PasapalabraId = 10, Letra = 'K', Pregunta = "¿Cómo se llama un tambor grande utilizado en orquestas y bandas militares?", Respuesta = "Kettledrum" },
                new PreguntaPasapalabra { Id = 248, PasapalabraId = 10, Letra = 'L', Pregunta = "¿Qué parte de una canción contiene las palabras que se cantan?", Respuesta = "Letra" },
                new PreguntaPasapalabra { Id = 249, PasapalabraId = 10, Letra = 'M', Pregunta = "¿Qué se llama a una secuencia de sonidos sucesivos que forman una unidad melódica?", Respuesta = "Melodía" },
                new PreguntaPasapalabra { Id = 250, PasapalabraId = 10, Letra = 'N', Pregunta = "¿Qué se utiliza para representar gráficamente el sonido en una partitura?", Respuesta = "Nota" },
                new PreguntaPasapalabra { Id = 251, PasapalabraId = 10, Letra = 'O', Pregunta = "¿Qué instrumento produce sonido mediante el paso de aire a través de tubos?", Respuesta = "Órgano" },
                new PreguntaPasapalabra { Id = 252, PasapalabraId = 10, Letra = 'P', Pregunta = "¿Qué instrumento de teclado se toca con los dedos?", Respuesta = "Piano" },
                new PreguntaPasapalabra { Id = 253, PasapalabraId = 10, Letra = 'Q', Pregunta = "¿Cómo se llama un grupo de cuatro músicos?", Respuesta = "Quarteto" },
                new PreguntaPasapalabra { Id = 254, PasapalabraId = 10, Letra = 'R', Pregunta = "¿Qué elemento marca la sucesión de sonidos en una pieza musical?", Respuesta = "Ritmo" },
                new PreguntaPasapalabra { Id = 255, PasapalabraId = 10, Letra = 'S', Pregunta = "¿Qué sistema de enseñanza musical utiliza símbolos para representar los sonidos?", Respuesta = "Solfeo" },
                new PreguntaPasapalabra { Id = 256, PasapalabraId = 10, Letra = 'T', Pregunta = "¿Qué instrumento de percusión se golpea para producir sonidos?", Respuesta = "Tambor" },
                new PreguntaPasapalabra { Id = 257, PasapalabraId = 10, Letra = 'U', Pregunta = "¿Qué instrumento tiene cuatro cuerdas y se toca con los dedos o con un plectro?", Respuesta = "Ukelele" },
                new PreguntaPasapalabra { Id = 258, PasapalabraId = 10, Letra = 'V', Pregunta = "¿Qué instrumento de cuerda se toca frotando las cuerdas con un arco?", Respuesta = "Violín" },
                new PreguntaPasapalabra { Id = 259, PasapalabraId = 10, Letra = 'W', Pregunta = "¿Qué instrumento se utiliza para hacer sonidos agudos soplando?", Respuesta = "Whistle" },
                new PreguntaPasapalabra { Id = 260, PasapalabraId = 10, Letra = 'X', Pregunta = "¿Qué instrumento de percusión tiene láminas que se golpean para producir sonido?", Respuesta = "Xilófono" },
                new PreguntaPasapalabra { Id = 261, PasapalabraId = 10, Letra = 'Y', Pregunta = "¿Qué parte de la baqueta se utiliza para golpear un tambor?", Respuesta = "Yema" },
                new PreguntaPasapalabra { Id = 262, PasapalabraId = 10, Letra = 'Z', Pregunta = "¿Qué tipo de patrón se forma con líneas que se juntan y separan de forma zigzagueante?", Respuesta = "Zigzag" }

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
        public DbSet<TipoJuego> TipoJuegos { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Pasapalabra> Pasapalabras { get; set; }
        public DbSet<PreguntaPasapalabra> PreguntaPasapalabras { get; set; }
        public DbSet<Resultados> Resultados { get; set; }


    }
}