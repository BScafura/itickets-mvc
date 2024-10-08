using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tickets.Data.Enums;
using Tickets.Models;
using System.Linq;

namespace Tickets.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"

                },
                new IdentityRole
                {

                    Name = "User",
                    NormalizedName = "USER"

                },
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            
            
            
            modelBuilder.Entity<Elenco>().HasKey(e => new
            {
                e.AtorId,
                e.FilmeId
            });

            modelBuilder.Entity<Elenco>().HasOne(f=> f.Filme).WithMany(e=> e.Elencos).HasForeignKey(f=> f.FilmeId);
            modelBuilder.Entity<Elenco>().HasOne(f => f.Ator).WithMany(e => e.Elencos).HasForeignKey(f => f.AtorId);

            modelBuilder.Entity<Ator>().HasData(
                new Ator()
                {
                    Id = 1,
                    NomeAtor = "Ator 1",
                    Bio = "This is the Bio of the first Ator",
                    FotoProfile = "http://dotnethow.net/images/actors/actor-1.jpeg"

                },
                        new Ator()
                        {
                            Id = 2,
                            NomeAtor = "Ator 2",
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Ator()
                        {
                            Id = 3,
                            NomeAtor = "Ator 3",
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Ator()
                        {
                            Id = 4,
                            NomeAtor = "Ator 4",
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Ator()
                        {
                            Id = 5,
                            NomeAtor = "Ator 5",
                            Bio = "This is the Bio of the second Ator",
                            FotoProfile = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }

                        );
            modelBuilder.Entity<Produtor>().HasData(
                 new Produtor()
                 {
                     Id = 1,
                     Nome = "Producer 1",
                     Bio = "This is the Bio of the first actor",
                     FotoProfile = "http://dotnethow.net/images/producers/producer-1.jpeg"

                 },
                        new Produtor()
                        {
                            Id = 2,
                            Nome = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Produtor()
                        {
                            Id = 3,
                            Nome = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Produtor()
                        {
                            Id = 4,
                            Nome = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Produtor()
                        {
                            Id = 5,
                            Nome = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            FotoProfile = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }

              );
            modelBuilder.Entity<Cinema>().HasData(
                new Cinema()
                {
                    Id = 1,
                    Nome = "Cinema 1",
                    Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                    Descricao = "This is the Descricao of the first cinema"
                },
                        new Cinema()
                        {
                            Id = 2,
                            Nome = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Descricao = "This is the Descricao of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 3,
                            Nome = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Descricao = "This is the Descricao of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 4,
                            Nome = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Descricao = "This is the Descricao of the first cinema"
                        },
                        new Cinema()
                        {
                            Id = 5,
                            Nome = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Descricao = "This is the Descricao of the first cinema"
                        }
                );

            modelBuilder.Entity<Filme>().HasData(
                new Filme()
                {
                    Id = 1,
                    Titulo = "Life",
                    Sinopse = "This is the Life movie Descricao",
                    Preco = 39.50,
                    Cartazurl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                    DataInicio = DateTime.Now.AddDays(-10),
                    DataFim = DateTime.Now.AddDays(10),
                    CinemaId = 3,
                    ProdutorId = 3,
                    MovieCategory = MovieCategory.Documentario
                },
                        new Filme()
                        {
                            Id = 2,
                            Titulo = "The Shawshank Redemption",
                            Sinopse = "This is the Shawshank Redemption Descricao",
                            Preco = 29.50,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            DataInicio = DateTime.Now,
                            DataFim = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProdutorId = 1,
                            MovieCategory = MovieCategory.Acao
                        },
                        new Filme()
                        {
                            Id = 3,
                            Titulo = "Ghost",
                            Sinopse = "This is the Ghost movie Descricao",
                            Preco = 39.50,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            DataInicio = DateTime.Now,
                            DataFim = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProdutorId = 4,
                            MovieCategory = MovieCategory.Terror
                        },
                        new Filme()
                        {
                            Id = 4,
                            Titulo = "Race",
                            Sinopse = "This is the Race movie Descricao",
                            Preco = 39.50,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            DataInicio = DateTime.Now.AddDays(-10),
                            DataFim = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProdutorId = 2,
                            MovieCategory = MovieCategory.Documentario
                        },
                        new Filme()
                        {
                            Id = 5,
                            Titulo = "Scoob",
                            Sinopse = "This is the Scoob movie Descricao",
                            Preco = 39.50,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            DataInicio = DateTime.Now.AddDays(-10),
                            DataFim = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProdutorId = 3,
                            MovieCategory = MovieCategory.Animacao
                        },
                        new Filme()
                        {
                            Id = 6,
                            Titulo = "Cold Soles",
                            Sinopse = "This is the Cold Soles movie Descricao",
                            Preco = 39.50,
                            Cartazurl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            DataInicio = DateTime.Now.AddDays(3),
                            DataFim = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProdutorId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
              );

            

            modelBuilder.Entity<Elenco>().HasData(
                 new Elenco()
                 {
                     AtorId = 1,
                     FilmeId = 1
                 },
                        new Elenco()
                        {
                            AtorId = 3,
                            FilmeId = 1
                        },

                         new Elenco()
                         {
                             AtorId = 1,
                             FilmeId = 2
                         },
                         new Elenco()
                         {
                             AtorId = 4,
                             FilmeId = 2
                         },

                        new Elenco()
                        {
                            AtorId = 1,
                            FilmeId = 3
                        },
                        new Elenco()
                        {
                            AtorId = 2,
                            FilmeId = 3
                        },
                        new Elenco()
                        {
                            AtorId = 5,
                            FilmeId = 3
                        },


                        new Elenco()
                        {
                            AtorId = 2,
                            FilmeId = 4
                        },
                        new Elenco()
                        {
                            AtorId = 3,
                            FilmeId = 4
                        },
                        new Elenco()
                        {
                            AtorId = 4,
                            FilmeId = 4
                        },


                        new Elenco()
                        {
                            AtorId = 2,
                            FilmeId = 5
                        },
                        new Elenco()
                        {
                            AtorId = 3,
                            FilmeId = 5
                        },
                        new Elenco()
                        {
                            AtorId = 4,
                            FilmeId = 5
                        },
                        new Elenco()
                        {
                            AtorId = 5,
                            FilmeId = 5
                        },


                        new Elenco()
                        {
                            AtorId = 3,
                            FilmeId = 6
                        },
                        new Elenco()
                        {
                            AtorId = 4,
                            FilmeId = 6
                        },
                        new Elenco()
                        {
                            AtorId = 5,
                            FilmeId = 6
                        }

              );



            base.OnModelCreating(modelBuilder);


        }

        public DbSet<Ator> Tatores { get; set; }
        public DbSet<Filme> Tfilmes { get; set; }
        public DbSet<Cinema> Tcinemas { get; set; }
        public DbSet<Elenco> Telencos { get; set; }
        public DbSet<Produtor> Tprodutores { get; set; }
        public DbSet<Ordem> Tordens{ get; set; }
        public DbSet<OrdemItem> Tordem_items { get; set; }
        public DbSet<CarrinhoDeComprasItem> Tcarrinho_items { get; set; }



    }
}
