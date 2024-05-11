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
                new Usuario { Id = 2, Name = "Antonio", Email = "antonio@svalero.com", Password = "1234", AvatarId = 1, Rol="Profesor" },
                new Usuario { Id = 3, Name = "Alex", Email = "alex@svalero.com", Password = "1234", AvatarId = 1, Rol="Alumno" }

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
                new Juego { Id = 1, IdCurso = 1, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Autores", Codigo = "XXXXXX" },
                new Juego { Id = 2, IdCurso = 1, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 3, IdCurso = 1, IdAsignatura = 1, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 4, IdCurso = 1, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 5, IdCurso = 1, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 6, IdCurso = 1, IdAsignatura = 2, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 7, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 8, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 9, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" },
                new Juego { Id = 10, IdCurso = 1, IdAsignatura = 3, IdTipoJuego = 1, TemaJuego = "Otra Cosa", Codigo = "XXXXXX" }

            );

            modelBuilder.Entity<Resultados>().HasData(
                new Resultados { Id = 1, IdJuego = 1, IdUsuario = 1, Resultado = 0.00 }
            );

            modelBuilder.Entity<Pasapalabra>().HasData(
                new Pasapalabra { Id = 1, Name = "Nombres de autores pasapalabra", IdJuego = 1 },
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
                new PreguntaPasapalabra { Id = 1, PasapalabraId = 1, Letra = 'A', Pregunta = "Nombre de autor que empieza por A", Respuesta = "Aaron" },
                new PreguntaPasapalabra { Id = 2, PasapalabraId = 1, Letra = 'B', Pregunta = "Fruta que empieza por B", Respuesta = "Banana" },
                new PreguntaPasapalabra { Id = 3, PasapalabraId = 1, Letra = 'C', Pregunta = "Animal que empieza por C", Respuesta = "Canguro" },
                new PreguntaPasapalabra { Id = 4, PasapalabraId = 1, Letra = 'D', Pregunta = "Capital europea que empieza por D", Respuesta = "Dublín" },
                new PreguntaPasapalabra { Id = 5, PasapalabraId = 1, Letra = 'E', Pregunta = "Elemento químico que empieza por E", Respuesta = "Estroncio" },
                new PreguntaPasapalabra { Id = 6, PasapalabraId = 1, Letra = 'F', Pregunta = "País asiático que empieza por F", Respuesta = "Filipinas" },
                new PreguntaPasapalabra { Id = 7, PasapalabraId = 1, Letra = 'G', Pregunta = "Deporte que empieza por G", Respuesta = "Golf" },
                new PreguntaPasapalabra { Id = 8, PasapalabraId = 1, Letra = 'H', Pregunta = "Instrumento musical que empieza por H", Respuesta = "Harmónica" },
                new PreguntaPasapalabra { Id = 9, PasapalabraId = 1, Letra = 'I', Pregunta = "Planeta que empieza por I", Respuesta = "Júpiter" },
                new PreguntaPasapalabra { Id = 10, PasapalabraId = 1, Letra = 'J', Pregunta = "Actor famoso que empieza por J", Respuesta = "Johnny Depp" },
                new PreguntaPasapalabra { Id = 11, PasapalabraId = 1, Letra = 'K', Pregunta = "Planta que empieza por K", Respuesta = "Kiwi" },
                new PreguntaPasapalabra { Id = 12, PasapalabraId = 1, Letra = 'L', Pregunta = "Color que empieza por L", Respuesta = "Lavanda" },
                new PreguntaPasapalabra { Id = 13, PasapalabraId = 1, Letra = 'M', Pregunta = "Cantante famoso que empieza por M", Respuesta = "Michael Jackson" },
                new PreguntaPasapalabra { Id = 14, PasapalabraId = 1, Letra = 'N', Pregunta = "Río que empieza por N", Respuesta = "Nilo" },
                new PreguntaPasapalabra { Id = 15, PasapalabraId = 1, Letra = 'O', Pregunta = "Película famosa que empieza por O", Respuesta = "El Origen" },
                new PreguntaPasapalabra { Id = 16, PasapalabraId = 1, Letra = 'P', Pregunta = "Instrumento de percusión que empieza por P", Respuesta = "Pandereta" },
                new PreguntaPasapalabra { Id = 17, PasapalabraId = 1, Letra = 'Q', Pregunta = "Animal exótico que empieza por Q", Respuesta = "Quokka" },
                new PreguntaPasapalabra { Id = 18, PasapalabraId = 1, Letra = 'R', Pregunta = "País africano que empieza por R", Respuesta = "Ruanda" },
                new PreguntaPasapalabra { Id = 19, PasapalabraId = 1, Letra = 'S', Pregunta = "Planta aromática que empieza por S", Respuesta = "Salvia" },
                new PreguntaPasapalabra { Id = 20, PasapalabraId = 1, Letra = 'T', Pregunta = "Elemento químico que empieza por T", Respuesta = "Tungsteno" },
                new PreguntaPasapalabra { Id = 21, PasapalabraId = 1, Letra = 'U', Pregunta = "País europeo que empieza por U", Respuesta = "Ucrania" },
                new PreguntaPasapalabra { Id = 22, PasapalabraId = 1, Letra = 'V', Pregunta = "Fruta que empieza por V", Respuesta = "Vainilla" },
                new PreguntaPasapalabra { Id = 23, PasapalabraId = 1, Letra = 'W', Pregunta = "Animal marino que empieza por W", Respuesta = "Ballena" },
                new PreguntaPasapalabra { Id = 24, PasapalabraId = 1, Letra = 'X', Pregunta = "Instrumento musical que empieza por X", Respuesta = "Xilófono" },
                new PreguntaPasapalabra { Id = 25, PasapalabraId = 1, Letra = 'Y', Pregunta = "Ciudad asiática que empieza por Y", Respuesta = "Yakarta" },
                new PreguntaPasapalabra { Id = 26, PasapalabraId = 1, Letra = 'Z', Pregunta = "Fruta tropical que empieza por Z", Respuesta = "Zarzamora" },

                new PreguntaPasapalabra { Id = 27, PasapalabraId = 2, Letra = 'A', Pregunta = "País sudamericano que empieza por A", Respuesta = "Argentina" },
                new PreguntaPasapalabra { Id = 28, PasapalabraId = 2, Letra = 'B', Pregunta = "Elemento químico que empieza por B", Respuesta = "Boro" },
                new PreguntaPasapalabra { Id = 29, PasapalabraId = 2, Letra = 'C', Pregunta = "Capital europea que empieza por C", Respuesta = "Copenhague" },
                new PreguntaPasapalabra { Id = 30, PasapalabraId = 2, Letra = 'D', Pregunta = "Actor de cine que empieza por D", Respuesta = "Denzel Washington" },
                new PreguntaPasapalabra { Id = 31, PasapalabraId = 2, Letra = 'E', Pregunta = "Animal salvaje que empieza por E", Respuesta = "Elefante" },
                new PreguntaPasapalabra { Id = 32, PasapalabraId = 2, Letra = 'F', Pregunta = "Deporte de invierno que empieza por F", Respuesta = "Fútbol" },
                new PreguntaPasapalabra { Id = 33, PasapalabraId = 2, Letra = 'G', Pregunta = "Ciudad europea que empieza por G", Respuesta = "Ginebra" },
                new PreguntaPasapalabra { Id = 34, PasapalabraId = 2, Letra = 'H', Pregunta = "Instrumento de viento que empieza por H", Respuesta = "Hornillo" },
                new PreguntaPasapalabra { Id = 35, PasapalabraId = 2, Letra = 'I', Pregunta = "Planeta que empieza por I", Respuesta = "Iapetus" },
                new PreguntaPasapalabra { Id = 36, PasapalabraId = 2, Letra = 'J', Pregunta = "Cantante famoso que empieza por J", Respuesta = "Justin Bieber" },
                new PreguntaPasapalabra { Id = 37, PasapalabraId = 2, Letra = 'K', Pregunta = "Fruta tropical que empieza por K", Respuesta = "Kumquat" },
                new PreguntaPasapalabra { Id = 38, PasapalabraId = 2, Letra = 'L', Pregunta = "Animal marino que empieza por L", Respuesta = "Langosta" },
                new PreguntaPasapalabra { Id = 39, PasapalabraId = 2, Letra = 'M', Pregunta = "País africano que empieza por M", Respuesta = "Mozambique" },
                new PreguntaPasapalabra { Id = 40, PasapalabraId = 2, Letra = 'N', Pregunta = "Comida típica mexicana que empieza por N", Respuesta = "Nopal" },
                new PreguntaPasapalabra { Id = 41, PasapalabraId = 2, Letra = 'O', Pregunta = "Actor famoso que empieza por O", Respuesta = "Orlando Bloom" },
                new PreguntaPasapalabra { Id = 42, PasapalabraId = 2, Letra = 'P', Pregunta = "Ciudad europea que empieza por P", Respuesta = "París" },
                new PreguntaPasapalabra { Id = 43, PasapalabraId = 2, Letra = 'Q', Pregunta = "Animal doméstico que empieza por Q", Respuesta = "Quagga" },
                new PreguntaPasapalabra { Id = 44, PasapalabraId = 2, Letra = 'R', Pregunta = "Elemento químico que empieza por R", Respuesta = "Radio" },
                new PreguntaPasapalabra { Id = 45, PasapalabraId = 2, Letra = 'S', Pregunta = "Cantante famosa que empieza por S", Respuesta = "Selena Gomez" },
                new PreguntaPasapalabra { Id = 46, PasapalabraId = 2, Letra = 'T', Pregunta = "Planta medicinal que empieza por T", Respuesta = "Tilo" },
                new PreguntaPasapalabra { Id = 47, PasapalabraId = 2, Letra = 'U', Pregunta = "País asiático que empieza por U", Respuesta = "Uzbekistán" },
                new PreguntaPasapalabra { Id = 48, PasapalabraId = 2, Letra = 'V', Pregunta = "Animal salvaje que empieza por V", Respuesta = "Víbora" },
                new PreguntaPasapalabra { Id = 49, PasapalabraId = 2, Letra = 'W', Pregunta = "Actor famoso que empieza por W", Respuesta = "Will Smith" },
                new PreguntaPasapalabra { Id = 50, PasapalabraId = 2, Letra = 'X', Pregunta = "Animal exótico que empieza por X", Respuesta = "Xoloitzcuintli" },
                new PreguntaPasapalabra { Id = 51, PasapalabraId = 2, Letra = 'Y', Pregunta = "Río que empieza por Y", Respuesta = "Yukón" },
                new PreguntaPasapalabra { Id = 52, PasapalabraId = 2, Letra = 'Z', Pregunta = "Fruta tropical que empieza por Z", Respuesta = "Zapote" }

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