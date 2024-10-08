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
    [Migration("20240504160839_chartmigration121")]
    partial class chartmigration121
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAtor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tatores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            NomeAtor = "Ator 1"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            NomeAtor = "Ator 2"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            NomeAtor = "Ator 3"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            NomeAtor = "Ator 4"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            NomeAtor = "Ator 5"
                        });
                });

            modelBuilder.Entity("Tickets.Models.CarrinhoDeComprasItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarrinhoDeComprasId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmeId");

                    b.ToTable("Tcarrinho_items");
                });

            modelBuilder.Entity("Tickets.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
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
                            DataFim = new DateTime(2024, 5, 14, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8493),
                            DataInicio = new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8433),
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
                            DataFim = new DateTime(2024, 5, 7, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8507),
                            DataInicio = new DateTime(2024, 5, 4, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8505),
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
                            DataFim = new DateTime(2024, 5, 11, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8512),
                            DataInicio = new DateTime(2024, 5, 4, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8510),
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
                            DataFim = new DateTime(2024, 4, 29, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8518),
                            DataInicio = new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8516),
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
                            DataFim = new DateTime(2024, 5, 2, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8523),
                            DataInicio = new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8521),
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
                            DataFim = new DateTime(2024, 5, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8529),
                            DataInicio = new DateTime(2024, 5, 7, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8527),
                            MovieCategory = 3,
                            Preco = 39.5,
                            ProdutorId = 5,
                            Sinopse = "This is the Cold Soles movie Descricao",
                            Titulo = "Cold Soles"
                        });
                });

            modelBuilder.Entity("Tickets.Models.Ordem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tordens");
                });

            modelBuilder.Entity("Tickets.Models.OrdemItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("OrdemId")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmeId");

                    b.HasIndex("OrdemId");

                    b.ToTable("Tordem_items");
                });

            modelBuilder.Entity("Tickets.Models.Produtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tprodutores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "This is the Bio of the first actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-1.jpeg",
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

            modelBuilder.Entity("Tickets.Models.CarrinhoDeComprasItem", b =>
                {
                    b.HasOne("Tickets.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId");

                    b.Navigation("Filme");
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
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets.Models.Produtor", "Produtor")
                        .WithMany("Filmes")
                        .HasForeignKey("ProdutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Produtor");
                });

            modelBuilder.Entity("Tickets.Models.OrdemItem", b =>
                {
                    b.HasOne("Tickets.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets.Models.Ordem", null)
                        .WithMany("OrdemItems")
                        .HasForeignKey("OrdemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filme");
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

            modelBuilder.Entity("Tickets.Models.Ordem", b =>
                {
                    b.Navigation("OrdemItems");
                });

            modelBuilder.Entity("Tickets.Models.Produtor", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}