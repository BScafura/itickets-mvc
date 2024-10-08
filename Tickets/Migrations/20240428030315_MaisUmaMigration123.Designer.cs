﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tickets.Data;

#nullable disable

namespace Tickets.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240428030315_MaisUmaMigration123")]
    partial class MaisUmaMigration123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tickets.Models.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tatores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Nome = "Ator 1"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Nome = "Ator 2"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            Nome = "Ator 3"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            Nome = "Ator 4"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            Nome = "Ator 5"
                        });
                });

            modelBuilder.Entity("Tickets.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tcinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "This is the Descricao of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Nome = "Cinema 1"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "This is the Descricao of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Nome = "Cinema 2"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "This is the Descricao of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Nome = "Cinema 3"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "This is the Descricao of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Nome = "Cinema 4"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "This is the Descricao of the first cinema",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Nome = "Cinema 5"
                        });
                });

            modelBuilder.Entity("Tickets.Models.Elenco", b =>
                {
                    b.Property<int>("AtorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.HasKey("AtorId", "FilmeId");

                    b.HasIndex("FilmeId");

                    b.ToTable("Telencos");

                    b.HasData(
                        new
                        {
                            AtorId = 1,
                            FilmeId = 1
                        },
                        new
                        {
                            AtorId = 3,
                            FilmeId = 1
                        },
                        new
                        {
                            AtorId = 1,
                            FilmeId = 2
                        },
                        new
                        {
                            AtorId = 4,
                            FilmeId = 2
                        },
                        new
                        {
                            AtorId = 1,
                            FilmeId = 3
                        },
                        new
                        {
                            AtorId = 2,
                            FilmeId = 3
                        },
                        new
                        {
                            AtorId = 5,
                            FilmeId = 3
                        },
                        new
                        {
                            AtorId = 2,
                            FilmeId = 4
                        },
                        new
                        {
                            AtorId = 3,
                            FilmeId = 4
                        },
                        new
                        {
                            AtorId = 4,
                            FilmeId = 4
                        },
                        new
                        {
                            AtorId = 2,
                            FilmeId = 5
                        },
                        new
                        {
                            AtorId = 3,
                            FilmeId = 5
                        },
                        new
                        {
                            AtorId = 4,
                            FilmeId = 5
                        },
                        new
                        {
                            AtorId = 5,
                            FilmeId = 5
                        },
                        new
                        {
                            AtorId = 3,
                            FilmeId = 6
                        },
                        new
                        {
                            AtorId = 4,
                            FilmeId = 6
                        },
                        new
                        {
                            AtorId = 5,
                            FilmeId = 6
                        });
                });

            modelBuilder.Entity("Tickets.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cartazurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CinemaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInicio")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<double?>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("ProdutorId")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProdutorId");

                    b.ToTable("Tfilmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            CinemaId = 3,
                            DataFim = new DateTime(2024, 5, 8, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1061),
                            DataInicio = new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1005),
                            MovieCategory = 4,
                            Preco = 39.5,
                            ProdutorId = 3,
                            Sinopse = "This is the Life movie Descricao",
                            Titulo = "Life"
                        },
                        new
                        {
                            Id = 2,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            CinemaId = 1,
                            DataFim = new DateTime(2024, 5, 1, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1068),
                            DataInicio = new DateTime(2024, 4, 28, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1067),
                            MovieCategory = 0,
                            Preco = 29.5,
                            ProdutorId = 1,
                            Sinopse = "This is the Shawshank Redemption Descricao",
                            Titulo = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = 3,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            CinemaId = 4,
                            DataFim = new DateTime(2024, 5, 5, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1073),
                            DataInicio = new DateTime(2024, 4, 28, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1071),
                            MovieCategory = 5,
                            Preco = 39.5,
                            ProdutorId = 4,
                            Sinopse = "This is the Ghost movie Descricao",
                            Titulo = "Ghost"
                        },
                        new
                        {
                            Id = 4,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            CinemaId = 1,
                            DataFim = new DateTime(2024, 4, 23, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1078),
                            DataInicio = new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1076),
                            MovieCategory = 4,
                            Preco = 39.5,
                            ProdutorId = 2,
                            Sinopse = "This is the Race movie Descricao",
                            Titulo = "Race"
                        },
                        new
                        {
                            Id = 5,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            CinemaId = 1,
                            DataFim = new DateTime(2024, 4, 26, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1082),
                            DataInicio = new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1081),
                            MovieCategory = 1,
                            Preco = 39.5,
                            ProdutorId = 3,
                            Sinopse = "This is the Scoob movie Descricao",
                            Titulo = "Scoob"
                        },
                        new
                        {
                            Id = 6,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            CinemaId = 1,
                            DataFim = new DateTime(2024, 5, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1087),
                            DataInicio = new DateTime(2024, 5, 1, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1085),
                            MovieCategory = 3,
                            Preco = 39.5,
                            ProdutorId = 5,
                            Sinopse = "This is the Cold Soles movie Descricao",
                            Titulo = "Cold Soles"
                        });
                });

            modelBuilder.Entity("Tickets.Models.Produtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tprodutores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FotoProfile = "http://dotnethow.net/images/produtores/producer-1.jpeg",
                            Nome = "Producer 1"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            Nome = "Producer 2"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            Nome = "Producer 3"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-4.jpeg",
                            Nome = "Producer 4"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-5.jpeg",
                            Nome = "Producer 5"
                        });
                });

            modelBuilder.Entity("Tickets.Models.Elenco", b =>
                {
                    b.HasOne("Tickets.Models.Ator", "Ator")
                        .WithMany("Elencos")
                        .HasForeignKey("AtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets.Models.Filme", "Filme")
                        .WithMany("Elencos")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ator");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("Tickets.Models.Filme", b =>
                {
                    b.HasOne("Tickets.Models.Cinema", "Cinema")
                        .WithMany("Filmes")
                        .HasForeignKey("CinemaId");

                    b.HasOne("Tickets.Models.Produtor", "Produtor")
                        .WithMany("Filmes")
                        .HasForeignKey("ProdutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Produtor");
                });

            modelBuilder.Entity("Tickets.Models.Ator", b =>
                {
                    b.Navigation("Elencos");
                });

            modelBuilder.Entity("Tickets.Models.Cinema", b =>
                {
                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("Tickets.Models.Filme", b =>
                {
                    b.Navigation("Elencos");
                });

            modelBuilder.Entity("Tickets.Models.Produtor", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}
