using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class chartmigration121 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tcarrinho_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmeId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoDeComprasId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tcarrinho_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tcarrinho_items_Tfilmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Tfilmes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 14, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 5, 4, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 5, 4, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 5, 7, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.CreateIndex(
                name: "IX_Tcarrinho_items_FilmeId",
                table: "Tcarrinho_items",
                column: "FilmeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tcarrinho_items");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 14, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 4, 24, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 5, 4, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 5, 4, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 4, 24, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 4, 24, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6801), new DateTime(2024, 5, 7, 17, 3, 22, 614, DateTimeKind.Local).AddTicks(6799) });
        }
    }
}
