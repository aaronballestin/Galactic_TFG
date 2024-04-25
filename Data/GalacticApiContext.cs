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
                new Usuario { Id = 1, Name = "Aaron", Email = "aaron@svalero.com", Password = "1234", AvatarId = 1 },
                new Usuario { Id = 2, Name = "Antonio", Email = "antonio@svalero.com", Password = "1234", AvatarId = 1 }
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
                new Asignatura { Id = 1, NombreAsignatura = "Lengua", CursoId = 1 },
                new Asignatura { Id = 2, NombreAsignatura = "Matematicas", CursoId = 1 },
                new Asignatura { Id = 3, NombreAsignatura = "Conocimiento del medio", CursoId = 1 },
                new Asignatura { Id = 4, NombreAsignatura = "Educación Artística", CursoId = 1 },
                new Asignatura { Id = 5, NombreAsignatura = "Ingles", CursoId = 1 },
                new Asignatura { Id = 6, NombreAsignatura = "Lengua", CursoId = 2 },
                new Asignatura { Id = 7, NombreAsignatura = "Matematicas", CursoId = 2 },
                new Asignatura { Id = 8, NombreAsignatura = "Conocimiento del medio", CursoId = 2 },
                new Asignatura { Id = 9, NombreAsignatura = "Educación Artística", CursoId = 2 },
                new Asignatura { Id = 10, NombreAsignatura = "Ingles", CursoId = 2 },
                new Asignatura { Id = 11, NombreAsignatura = "Lengua", CursoId = 3 },
                new Asignatura { Id = 12, NombreAsignatura = "Matematicas", CursoId = 3 },
                new Asignatura { Id = 13, NombreAsignatura = "Conocimiento del medio", CursoId = 3 },
                new Asignatura { Id = 14, NombreAsignatura = "Educación Artística", CursoId = 3 },
                new Asignatura { Id = 15, NombreAsignatura = "Ingles", CursoId = 3 },
                new Asignatura { Id = 16, NombreAsignatura = "Lengua", CursoId = 4 },
                new Asignatura { Id = 17, NombreAsignatura = "Matematicas", CursoId = 4 },
                new Asignatura { Id = 18, NombreAsignatura = "Conocimiento del medio", CursoId = 4 },
                new Asignatura { Id = 19, NombreAsignatura = "Educación Artística", CursoId = 4 },
                new Asignatura { Id = 20, NombreAsignatura = "Ingles", CursoId = 4 },
                new Asignatura { Id = 21, NombreAsignatura = "Lengua", CursoId = 5 },
                new Asignatura { Id = 22, NombreAsignatura = "Matematicas", CursoId = 5 },
                new Asignatura { Id = 23, NombreAsignatura = "Conocimiento del medio", CursoId = 5 },
                new Asignatura { Id = 24, NombreAsignatura = "Educación Artística", CursoId = 5 },
                new Asignatura { Id = 25, NombreAsignatura = "Ingles", CursoId = 5 },
                new Asignatura { Id = 26, NombreAsignatura = "Lengua", CursoId = 6 },
                new Asignatura { Id = 27, NombreAsignatura = "Matematicas", CursoId = 6 },
                new Asignatura { Id = 28, NombreAsignatura = "Conocimiento del medio", CursoId = 6 },
                new Asignatura { Id = 29, NombreAsignatura = "Educación Artística", CursoId = 6 },
                new Asignatura { Id = 30, NombreAsignatura = "Ingles", CursoId = 6 }
            );

            modelBuilder.Entity<TipoJuego>().HasData(
                new TipoJuego { Id = 1, Tipo = "Pasapalabra" }
            );

            modelBuilder.Entity<AsignaturaJuego>().HasData(
                new AsignaturaJuego { Id = 1, JuegoAsignatura = "Pasapalabra Lengua 1º", IdAsignatura = 1, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 2, JuegoAsignatura = "Pasapalabra Lengua 2º", IdAsignatura = 6, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 3, JuegoAsignatura = "Pasapalabra Lengua 3º", IdAsignatura = 11, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 4, JuegoAsignatura = "Pasapalabra Lengua 4º", IdAsignatura = 16, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 5, JuegoAsignatura = "Pasapalabra Lengua 5º", IdAsignatura = 21, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 6, JuegoAsignatura = "Pasapalabra Lengua 6º", IdAsignatura = 26, IdTipoJuego = 1 },

                new AsignaturaJuego { Id = 7, JuegoAsignatura = "Pasapalabra Matematicas 1º", IdAsignatura = 2, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 8, JuegoAsignatura = "Pasapalabra Matematicas 2º", IdAsignatura = 7, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 9, JuegoAsignatura = "Pasapalabra Matematicas 3º", IdAsignatura = 12, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 10, JuegoAsignatura = "Pasapalabra Matematicas 4º", IdAsignatura = 17, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 11, JuegoAsignatura = "Pasapalabra Matematicas 5º", IdAsignatura = 22, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 12, JuegoAsignatura = "Pasapalabra Matematicas 6º", IdAsignatura = 27, IdTipoJuego = 1 },

                new AsignaturaJuego { Id = 13, JuegoAsignatura = "Pasapalabra Conocimiento del medio 1º", IdAsignatura = 3, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 14, JuegoAsignatura = "Pasapalabra Conocimiento del medio 2º", IdAsignatura = 8, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 15, JuegoAsignatura = "Pasapalabra Conocimiento del medio 3º", IdAsignatura = 13, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 16, JuegoAsignatura = "Pasapalabra Conocimiento del medio 4º", IdAsignatura = 18, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 17, JuegoAsignatura = "Pasapalabra Conocimiento del medio 5º", IdAsignatura = 23, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 18, JuegoAsignatura = "Pasapalabra Conocimiento del medio 6º", IdAsignatura = 28, IdTipoJuego = 1 },

                new AsignaturaJuego { Id = 19, JuegoAsignatura = "Pasapalabra Educación Artística 1º", IdAsignatura = 4, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 20, JuegoAsignatura = "Pasapalabra Educación Artística 2º", IdAsignatura = 9, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 21, JuegoAsignatura = "Pasapalabra Educación Artística 3º", IdAsignatura = 14, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 22, JuegoAsignatura = "Pasapalabra Educación Artística 4º", IdAsignatura = 19, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 23, JuegoAsignatura = "Pasapalabra Educación Artística 5º", IdAsignatura = 24, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 24, JuegoAsignatura = "Pasapalabra Educación Artística 6º", IdAsignatura = 29, IdTipoJuego = 1 },

                new AsignaturaJuego { Id = 25, JuegoAsignatura = "Pasapalabra Ingles 1º", IdAsignatura = 5, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 26, JuegoAsignatura = "Pasapalabra Ingles 2º", IdAsignatura = 10, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 27, JuegoAsignatura = "Pasapalabra Ingles 3º", IdAsignatura = 15, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 28, JuegoAsignatura = "Pasapalabra Ingles 4º", IdAsignatura = 20, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 29, JuegoAsignatura = "Pasapalabra Ingles 5º", IdAsignatura = 25, IdTipoJuego = 1 },
                new AsignaturaJuego { Id = 30, JuegoAsignatura = "Pasapalabra Ingles 6º", IdAsignatura = 30, IdTipoJuego = 1 }
            );

            modelBuilder.Entity<Juego>().HasData(
                new Juego { Id = 1, IdAsignaturaJuego = 1, TemaJuego = "Autores", Codigo = "XXXXXX" }
            );

            modelBuilder.Entity<Resultados>().HasData(
                new Resultados {Id = 1, IdJuego = 1, IdUsuario = 1, Resultado = 0.00 }
            );

            modelBuilder.Entity<Pasapalabra>().HasData(
                new Pasapalabra { Id = 1, Name = "Nombres de autores pasapalabra", IdJuego = 1 }
            );

            modelBuilder.Entity<PreguntaPasapalabra>().HasData(
                new PreguntaPasapalabra { Id = 1, IdPasapalabra = 1, Letra = 'A', Pregunta = "Nombre de autor que empieza por A", Respuesta = "Aaron" }
            );



            // Relación entre Usuario y Avatar
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Avatar)
                .WithMany(a => a.Usuarios)
                .HasForeignKey(u => u.AvatarId)
                .IsRequired();

            // Relación entre Curso y Asignatura
            // modelBuilder.Entity<Curso>()
            //     .HasMany(c => c.Asignaturas)
            //     .WithOne(a => a.Curso)
            //     .HasForeignKey(a => a.CursoId)
            //     .IsRequired();

            // Relación entre Asignatura y AsignaturaJuego
            modelBuilder.Entity<Asignatura>()
                .HasMany(a => a.AsignaturaJuegos)
                .WithOne(aj => aj.Asignatura)
                .HasForeignKey(aj => aj.IdAsignatura)
                .IsRequired();

            // Relación entre TipoJuego y AsignaturaJuego
            modelBuilder.Entity<TipoJuego>()
                .HasMany(tj => tj.AsignaturaJuegos)
                .WithOne(aj => aj.TipoJuego)
                .HasForeignKey(aj => aj.IdTipoJuego)
                .IsRequired();

            // Relación entre TipoJuego y AsignaturaJuego
            modelBuilder.Entity<AsignaturaJuego>()
                .HasOne(aj => aj.TipoJuego)
                .WithMany(tj => tj.AsignaturaJuegos)
                .HasForeignKey(aj => aj.IdTipoJuego)
                .IsRequired();

            // Relación entre AsignaturaJuego y Juego
            modelBuilder.Entity<Juego>()
                .HasOne(j => j.AsignaturaJuego)
                .WithMany(aj => aj.Juego)
                .HasForeignKey(j => j.IdAsignaturaJuego)
                .IsRequired();

            // Relación entre Juego y Pasapalabra
            modelBuilder.Entity<Juego>()
                .HasOne(j => j.Pasapalabra)
                .WithOne(p => p.Juego)
                .HasForeignKey<Pasapalabra>(p => p.IdJuego)
                .IsRequired();



            // Relación entre Pasapalabra y PreguntaPasapalabra
            modelBuilder.Entity<PreguntaPasapalabra>()
                .HasOne(pp => pp.Pasapalabra)
                .WithMany(p => p.PreguntaPasapalabras)
                .HasForeignKey(pp => pp.IdPasapalabra)
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
        public DbSet <Resultados> resultados{ get; set; }


    }
}