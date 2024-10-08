using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class MaisUmaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tatores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cartazurl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieCategory = table.Column<int>(type: "int", nullable: false),
                    ProdutorId = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmes_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Filmes_Produtores_ProdutorId",
                        column: x => x.ProdutorId,
                        principalTable: "Produtores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elencos",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "int", nullable: false),
                    AtorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elencos", x => new { x.AtorId, x.FilmeId });
                    table.ForeignKey(
                        name: "FK_Elencos_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Elencos_Tatores_AtorId",
                        column: x => x.AtorId,
                        principalTable: "Tatores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Descricao", "Logo", "Nome" },
                values: new object[,]
                {
                    { 1, "This is the Descricao of the first cinema", "http://dotnethow.net/images/cinemas/cinema-1.jpeg", "Cinema 1" },
                    { 2, "This is the Descricao of the first cinema", "http://dotnethow.net/images/cinemas/cinema-2.jpeg", "Cinema 2" },
                    { 3, "This is the Descricao of the first cinema", "http://dotnethow.net/images/cinemas/cinema-3.jpeg", "Cinema 3" },
                    { 4, "This is the Descricao of the first cinema", "http://dotnethow.net/images/cinemas/cinema-4.jpeg", "Cinema 4" },
                    { 5, "This is the Descricao of the first cinema", "http://dotnethow.net/images/cinemas/cinema-5.jpeg", "Cinema 5" }
                });

            migrationBuilder.InsertData(
                table: "Produtores",
                columns: new[] { "Id", "Bio", "FotoProfile", "Nome" },
                values: new object[,]
                {
                    { 1, "This is the Bio of the first actor", "http://dotnethow.net/images/produtores/producer-1.jpeg", "Producer 1" },
                    { 2, "This is the Bio of the second actor", "http://dotnethow.net/images/producers/producer-2.jpeg", "Producer 2" },
                    { 3, "This is the Bio of the second actor", "http://dotnethow.net/images/producers/producer-3.jpeg", "Producer 3" },
                    { 4, "This is the Bio of the second actor", "http://dotnethow.net/images/producers/producer-4.jpeg", "Producer 4" },
                    { 5, "This is the Bio of the second actor", "http://dotnethow.net/images/producers/producer-5.jpeg", "Producer 5" }
                });

            migrationBuilder.InsertData(
                table: "Tatores",
                columns: new[] { "Id", "Bio", "FotoProfile", "Nome" },
                values: new object[,]
                {
                    { 1, "This is the Bio of the first Ator", "http://dotnethow.net/images/actors/actor-1.jpeg", "Ator 1" },
                    { 2, "This is the Bio of the second Ator", "http://dotnethow.net/images/actors/actor-2.jpeg", "Ator 2" },
                    { 3, "This is the Bio of the second Ator", "http://dotnethow.net/images/actors/actor-3.jpeg", "Ator 3" },
                    { 4, "This is the Bio of the second Ator", "http://dotnethow.net/images/actors/actor-4.jpeg", "Ator 4" },
                    { 5, "This is the Bio of the second Ator", "http://dotnethow.net/images/actors/actor-5.jpeg", "Ator 5" }
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Cartazurl", "CinemaId", "DataFim", "DataInicio", "MovieCategory", "Preco", "ProdutorId", "Sinopse", "Titulo" },
                values: new object[,]
                {
                    { 1, "http://dotnethow.net/images/movies/movie-3.jpeg", 3, new DateTime(2024, 5, 8, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8387), new DateTime(2024, 4, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8328), 4, 39.5, 3, "This is the Life movie Descricao", "Life" },
                    { 2, "http://dotnethow.net/images/movies/movie-1.jpeg", 1, new DateTime(2024, 5, 1, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 4, 28, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8394), 0, 29.5, 1, "This is the Shawshank Redemption Descricao", "The Shawshank Redemption" },
                    { 3, "http://dotnethow.net/images/movies/movie-4.jpeg", 4, new DateTime(2024, 5, 5, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 4, 28, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8399), 5, 39.5, 4, "This is the Ghost movie Descricao", "Ghost" },
                    { 4, "http://dotnethow.net/images/movies/movie-6.jpeg", 1, new DateTime(2024, 4, 23, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 4, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8403), 4, 39.5, 2, "This is the Race movie Descricao", "Race" },
                    { 5, "http://dotnethow.net/images/movies/movie-7.jpeg", 1, new DateTime(2024, 4, 26, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 4, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8408), 1, 39.5, 3, "This is the Scoob movie Descricao", "Scoob" },
                    { 6, "http://dotnethow.net/images/movies/movie-8.jpeg", 1, new DateTime(2024, 5, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 5, 1, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8412), 3, 39.5, 5, "This is the Cold Soles movie Descricao", "Cold Soles" }
                });

            migrationBuilder.InsertData(
                table: "Elencos",
                columns: new[] { "AtorId", "FilmeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elencos_FilmeId",
                table: "Elencos",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_CinemaId",
                table: "Filmes",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_ProdutorId",
                table: "Filmes",
                column: "ProdutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elencos");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Tatores");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Produtores");
        }
    }
}
