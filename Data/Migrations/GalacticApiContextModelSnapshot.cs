﻿// <auto-generated />
using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalacticApi.Data.Migrations
{
    [DbContext(typeof(GalacticApiContext))]
    partial class GalacticApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GalacticApi.Models.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreAsignatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Asignaturas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CursoId = 1,
                            NombreAsignatura = "Lengua"
                        },
                        new
                        {
                            Id = 2,
                            CursoId = 1,
                            NombreAsignatura = "Matematicas"
                        },
                        new
                        {
                            Id = 3,
                            CursoId = 1,
                            NombreAsignatura = "Conocimiento del medio"
                        },
                        new
                        {
                            Id = 4,
                            CursoId = 1,
                            NombreAsignatura = "Educación Artística"
                        },
                        new
                        {
                            Id = 5,
                            CursoId = 1,
                            NombreAsignatura = "Ingles"
                        },
                        new
                        {
                            Id = 6,
                            CursoId = 2,
                            NombreAsignatura = "Lengua"
                        },
                        new
                        {
                            Id = 7,
                            CursoId = 2,
                            NombreAsignatura = "Matematicas"
                        },
                        new
                        {
                            Id = 8,
                            CursoId = 2,
                            NombreAsignatura = "Conocimiento del medio"
                        },
                        new
                        {
                            Id = 9,
                            CursoId = 2,
                            NombreAsignatura = "Educación Artística"
                        },
                        new
                        {
                            Id = 10,
                            CursoId = 2,
                            NombreAsignatura = "Ingles"
                        },
                        new
                        {
                            Id = 11,
                            CursoId = 3,
                            NombreAsignatura = "Lengua"
                        },
                        new
                        {
                            Id = 12,
                            CursoId = 3,
                            NombreAsignatura = "Matematicas"
                        },
                        new
                        {
                            Id = 13,
                            CursoId = 3,
                            NombreAsignatura = "Conocimiento del medio"
                        },
                        new
                        {
                            Id = 14,
                            CursoId = 3,
                            NombreAsignatura = "Educación Artística"
                        },
                        new
                        {
                            Id = 15,
                            CursoId = 3,
                            NombreAsignatura = "Ingles"
                        },
                        new
                        {
                            Id = 16,
                            CursoId = 4,
                            NombreAsignatura = "Lengua"
                        },
                        new
                        {
                            Id = 17,
                            CursoId = 4,
                            NombreAsignatura = "Matematicas"
                        },
                        new
                        {
                            Id = 18,
                            CursoId = 4,
                            NombreAsignatura = "Conocimiento del medio"
                        },
                        new
                        {
                            Id = 19,
                            CursoId = 4,
                            NombreAsignatura = "Educación Artística"
                        },
                        new
                        {
                            Id = 20,
                            CursoId = 4,
                            NombreAsignatura = "Ingles"
                        },
                        new
                        {
                            Id = 21,
                            CursoId = 5,
                            NombreAsignatura = "Lengua"
                        },
                        new
                        {
                            Id = 22,
                            CursoId = 5,
                            NombreAsignatura = "Matematicas"
                        },
                        new
                        {
                            Id = 23,
                            CursoId = 5,
                            NombreAsignatura = "Conocimiento del medio"
                        },
                        new
                        {
                            Id = 24,
                            CursoId = 5,
                            NombreAsignatura = "Educación Artística"
                        },
                        new
                        {
                            Id = 25,
                            CursoId = 5,
                            NombreAsignatura = "Ingles"
                        },
                        new
                        {
                            Id = 26,
                            CursoId = 6,
                            NombreAsignatura = "Lengua"
                        },
                        new
                        {
                            Id = 27,
                            CursoId = 6,
                            NombreAsignatura = "Matematicas"
                        },
                        new
                        {
                            Id = 28,
                            CursoId = 6,
                            NombreAsignatura = "Conocimiento del medio"
                        },
                        new
                        {
                            Id = 29,
                            CursoId = 6,
                            NombreAsignatura = "Educación Artística"
                        },
                        new
                        {
                            Id = 30,
                            CursoId = 6,
                            NombreAsignatura = "Ingles"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.AsignaturaJuego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdAsignatura")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoJuego")
                        .HasColumnType("int");

                    b.Property<string>("JuegoAsignatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTipoJuego");

                    b.ToTable("AsignaturaJuegos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdAsignatura = 1,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Lengua 1º"
                        },
                        new
                        {
                            Id = 2,
                            IdAsignatura = 6,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Lengua 2º"
                        },
                        new
                        {
                            Id = 3,
                            IdAsignatura = 11,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Lengua 3º"
                        },
                        new
                        {
                            Id = 4,
                            IdAsignatura = 16,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Lengua 4º"
                        },
                        new
                        {
                            Id = 5,
                            IdAsignatura = 21,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Lengua 5º"
                        },
                        new
                        {
                            Id = 6,
                            IdAsignatura = 26,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Lengua 6º"
                        },
                        new
                        {
                            Id = 7,
                            IdAsignatura = 2,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Matematicas 1º"
                        },
                        new
                        {
                            Id = 8,
                            IdAsignatura = 7,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Matematicas 2º"
                        },
                        new
                        {
                            Id = 9,
                            IdAsignatura = 12,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Matematicas 3º"
                        },
                        new
                        {
                            Id = 10,
                            IdAsignatura = 17,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Matematicas 4º"
                        },
                        new
                        {
                            Id = 11,
                            IdAsignatura = 22,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Matematicas 5º"
                        },
                        new
                        {
                            Id = 12,
                            IdAsignatura = 27,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Matematicas 6º"
                        },
                        new
                        {
                            Id = 13,
                            IdAsignatura = 3,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Conocimiento del medio 1º"
                        },
                        new
                        {
                            Id = 14,
                            IdAsignatura = 8,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Conocimiento del medio 2º"
                        },
                        new
                        {
                            Id = 15,
                            IdAsignatura = 13,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Conocimiento del medio 3º"
                        },
                        new
                        {
                            Id = 16,
                            IdAsignatura = 18,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Conocimiento del medio 4º"
                        },
                        new
                        {
                            Id = 17,
                            IdAsignatura = 23,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Conocimiento del medio 5º"
                        },
                        new
                        {
                            Id = 18,
                            IdAsignatura = 28,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Conocimiento del medio 6º"
                        },
                        new
                        {
                            Id = 19,
                            IdAsignatura = 4,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Educación Artística 1º"
                        },
                        new
                        {
                            Id = 20,
                            IdAsignatura = 9,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Educación Artística 2º"
                        },
                        new
                        {
                            Id = 21,
                            IdAsignatura = 14,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Educación Artística 3º"
                        },
                        new
                        {
                            Id = 22,
                            IdAsignatura = 19,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Educación Artística 4º"
                        },
                        new
                        {
                            Id = 23,
                            IdAsignatura = 24,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Educación Artística 5º"
                        },
                        new
                        {
                            Id = 24,
                            IdAsignatura = 29,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Educación Artística 6º"
                        },
                        new
                        {
                            Id = 25,
                            IdAsignatura = 5,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Ingles 1º"
                        },
                        new
                        {
                            Id = 26,
                            IdAsignatura = 10,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Ingles 2º"
                        },
                        new
                        {
                            Id = 27,
                            IdAsignatura = 15,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Ingles 3º"
                        },
                        new
                        {
                            Id = 28,
                            IdAsignatura = 20,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Ingles 4º"
                        },
                        new
                        {
                            Id = 29,
                            IdAsignatura = 25,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Ingles 5º"
                        },
                        new
                        {
                            Id = 30,
                            IdAsignatura = 30,
                            IdTipoJuego = 1,
                            JuegoAsignatura = "Pasapalabra Ingles 6º"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Avatar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoJuego")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Premium")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("RutaFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Avatars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodigoJuego = "XXXXXX",
                            Premium = "N",
                            RutaFoto = ""
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoId"), 1L, 1);

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            NombreCurso = "1º Primaria"
                        },
                        new
                        {
                            CursoId = 2,
                            NombreCurso = "2º Primaria"
                        },
                        new
                        {
                            CursoId = 3,
                            NombreCurso = "3º Primaria"
                        },
                        new
                        {
                            CursoId = 4,
                            NombreCurso = "4º Primaria"
                        },
                        new
                        {
                            CursoId = 5,
                            NombreCurso = "5º Primaria"
                        },
                        new
                        {
                            CursoId = 6,
                            NombreCurso = "6º Primaria"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Juego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAsignaturaJuego")
                        .HasColumnType("int");

                    b.Property<string>("TemaJuego")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAsignaturaJuego");

                    b.ToTable("Juegos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "XXXXXX",
                            IdAsignaturaJuego = 1,
                            TemaJuego = "Autores"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Pasapalabra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdJuego")
                        .IsUnique();

                    b.ToTable("Pasapalabras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdJuego = 1,
                            Name = "Nombres de autores pasapalabra"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.PreguntaPasapalabra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdPasapalabra")
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Pregunta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Respuesta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPasapalabra");

                    b.ToTable("PreguntaPasapalabras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdPasapalabra = 1,
                            Letra = "A",
                            Pregunta = "Nombre de autor que empieza por A",
                            Respuesta = "Aaron"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Resultados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdJuego")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<double>("Resultado")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdJuego");

                    b.HasIndex("IdUsuario");

                    b.ToTable("resultados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdJuego = 1,
                            IdUsuario = 1,
                            Resultado = 0.0
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.TipoJuego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoJuegos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tipo = "Pasapalabra"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvatarId = 1,
                            Email = "aaron@svalero.com",
                            Name = "Aaron",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            AvatarId = 1,
                            Email = "antonio@svalero.com",
                            Name = "Antonio",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("GalacticApi.Models.Asignatura", b =>
                {
                    b.HasOne("GalacticApi.Models.Curso", "Curso")
                        .WithMany("Asignaturas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("GalacticApi.Models.AsignaturaJuego", b =>
                {
                    b.HasOne("GalacticApi.Models.Asignatura", "Asignatura")
                        .WithMany("AsignaturaJuegos")
                        .HasForeignKey("IdAsignatura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalacticApi.Models.TipoJuego", "TipoJuego")
                        .WithMany("AsignaturaJuegos")
                        .HasForeignKey("IdTipoJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignatura");

                    b.Navigation("TipoJuego");
                });

            modelBuilder.Entity("GalacticApi.Models.Juego", b =>
                {
                    b.HasOne("GalacticApi.Models.AsignaturaJuego", "AsignaturaJuego")
                        .WithMany("Juegos")
                        .HasForeignKey("IdAsignaturaJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AsignaturaJuego");
                });

            modelBuilder.Entity("GalacticApi.Models.Pasapalabra", b =>
                {
                    b.HasOne("GalacticApi.Models.Juego", "Juego")
                        .WithOne("Pasapalabra")
                        .HasForeignKey("GalacticApi.Models.Pasapalabra", "IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");
                });

            modelBuilder.Entity("GalacticApi.Models.PreguntaPasapalabra", b =>
                {
                    b.HasOne("GalacticApi.Models.Pasapalabra", "Pasapalabra")
                        .WithMany("PreguntaPasapalabras")
                        .HasForeignKey("IdPasapalabra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pasapalabra");
                });

            modelBuilder.Entity("GalacticApi.Models.Resultados", b =>
                {
                    b.HasOne("GalacticApi.Models.Juego", "Juego")
                        .WithMany("Resultados")
                        .HasForeignKey("IdJuego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalacticApi.Models.Usuario", "Usuario")
                        .WithMany("Resultados")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Juego");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GalacticApi.Models.Usuario", b =>
                {
                    b.HasOne("GalacticApi.Models.Avatar", "Avatar")
                        .WithMany("Usuarios")
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("GalacticApi.Models.Asignatura", b =>
                {
                    b.Navigation("AsignaturaJuegos");
                });

            modelBuilder.Entity("GalacticApi.Models.AsignaturaJuego", b =>
                {
                    b.Navigation("Juegos");
                });

            modelBuilder.Entity("GalacticApi.Models.Avatar", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GalacticApi.Models.Curso", b =>
                {
                    b.Navigation("Asignaturas");
                });

            modelBuilder.Entity("GalacticApi.Models.Juego", b =>
                {
                    b.Navigation("Pasapalabra")
                        .IsRequired();

                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("GalacticApi.Models.Pasapalabra", b =>
                {
                    b.Navigation("PreguntaPasapalabras");
                });

            modelBuilder.Entity("GalacticApi.Models.TipoJuego", b =>
                {
                    b.Navigation("AsignaturaJuegos");
                });

            modelBuilder.Entity("GalacticApi.Models.Usuario", b =>
                {
                    b.Navigation("Resultados");
                });
#pragma warning restore 612, 618
        }
    }
}
