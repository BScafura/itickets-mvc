using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class MaisUmaMigration123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elencos_Filmes_FilmeId",
                table: "Elencos");

            migrationBuilder.DropForeignKey(
                name: "FK_Elencos_Tatores_AtorId",
                table: "Elencos");

            migrationBuilder.DropForeignKey(
                name: "FK_Filmes_Cinemas_CinemaId",
                table: "Filmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Filmes_Produtores_ProdutorId",
                table: "Filmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtores",
                table: "Produtores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Elencos",
                table: "Elencos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Produtores",
                newName: "Tprodutores");

            migrationBuilder.RenameTable(
                name: "Filmes",
                newName: "Tfilmes");

            migrationBuilder.RenameTable(
                name: "Elencos",
                newName: "Telencos");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Tcinemas");

            migrationBuilder.RenameIndex(
                name: "IX_Filmes_ProdutorId",
                table: "Tfilmes",
                newName: "IX_Tfilmes_ProdutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Filmes_CinemaId",
                table: "Tfilmes",
                newName: "IX_Tfilmes_CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Elencos_FilmeId",
                table: "Telencos",
                newName: "IX_Telencos_FilmeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tprodutores",
                table: "Tprodutores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tfilmes",
                table: "Tfilmes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telencos",
                table: "Telencos",
                columns: new[] { "AtorId", "FilmeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tcinemas",
                table: "Tcinemas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 4, 28, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 4, 28, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 5, 1, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.AddForeignKey(
                name: "FK_Telencos_Tatores_AtorId",
                table: "Telencos",
                column: "AtorId",
                principalTable: "Tatores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telencos_Tfilmes_FilmeId",
                table: "Telencos",
                column: "FilmeId",
                principalTable: "Tfilmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tfilmes_Tcinemas_CinemaId",
                table: "Tfilmes",
                column: "CinemaId",
                principalTable: "Tcinemas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tfilmes_Tprodutores_ProdutorId",
                table: "Tfilmes",
                column: "ProdutorId",
                principalTable: "Tprodutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telencos_Tatores_AtorId",
                table: "Telencos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telencos_Tfilmes_FilmeId",
                table: "Telencos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tfilmes_Tcinemas_CinemaId",
                table: "Tfilmes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tfilmes_Tprodutores_ProdutorId",
                table: "Tfilmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tprodutores",
                table: "Tprodutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tfilmes",
                table: "Tfilmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telencos",
                table: "Telencos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tcinemas",
                table: "Tcinemas");

            migrationBuilder.RenameTable(
                name: "Tprodutores",
                newName: "Produtores");

            migrationBuilder.RenameTable(
                name: "Tfilmes",
                newName: "Filmes");

            migrationBuilder.RenameTable(
                name: "Telencos",
                newName: "Elencos");

            migrationBuilder.RenameTable(
                name: "Tcinemas",
                newName: "Cinemas");

            migrationBuilder.RenameIndex(
                name: "IX_Tfilmes_ProdutorId",
                table: "Filmes",
                newName: "IX_Filmes_ProdutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Tfilmes_CinemaId",
                table: "Filmes",
                newName: "IX_Filmes_CinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Telencos_FilmeId",
                table: "Elencos",
                newName: "IX_Elencos_FilmeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtores",
                table: "Produtores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Elencos",
                table: "Elencos",
                columns: new[] { "AtorId", "FilmeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8387), new DateTime(2024, 4, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 4, 28, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 4, 28, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 4, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 4, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 5, 1, 4, 0, 53, 624, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.AddForeignKey(
                name: "FK_Elencos_Filmes_FilmeId",
                table: "Elencos",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Elencos_Tatores_AtorId",
                table: "Elencos",
                column: "AtorId",
                principalTable: "Tatores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filmes_Cinemas_CinemaId",
                table: "Filmes",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmes_Produtores_ProdutorId",
                table: "Filmes",
                column: "ProdutorId",
                principalTable: "Produtores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
