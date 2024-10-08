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
    [Migration("20240514203511_Identityadd")]
    partial class Identityadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Tickets.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<int>("MyProperty1")
                        .HasColumnType("int");

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

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
                            DataFim = new DateTime(2024, 5, 24, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9153),
                            DataInicio = new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9101),
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
                            DataFim = new DateTime(2024, 5, 17, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9160),
                            DataInicio = new DateTime(2024, 5, 14, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9158),
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
                            DataFim = new DateTime(2024, 5, 21, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9164),
                            DataInicio = new DateTime(2024, 5, 14, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9163),
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
                            DataFim = new DateTime(2024, 5, 9, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9169),
                            DataInicio = new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9167),
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
                            DataFim = new DateTime(2024, 5, 12, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9173),
                            DataInicio = new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9171),
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
                            DataFim = new DateTime(2024, 6, 3, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9177),
                            DataInicio = new DateTime(2024, 5, 17, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9175),
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Tickets.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Tickets.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Tickets.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
