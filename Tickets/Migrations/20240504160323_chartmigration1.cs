using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class chartmigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tordens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tordens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tordem_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    FilmeId = table.Column<int>(type: "int", nullable: false),
                    OrdemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tordem_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tordem_items_Tfilmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Tfilmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tordem_items_Tordens_OrdemId",
                        column: x => x.OrdemId,
                        principalTable: "Tordens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tordem_items_FilmeId",
                table: "Tordem_items",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tordem_items_OrdemId",
                table: "Tordem_items",
                column: "OrdemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tordem_items");

            migrationBuilder.DropTable(
                name: "Tordens");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 4, 22, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(204), new DateTime(2024, 5, 2, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 5, 2, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 27, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 4, 22, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 30, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(225), new DateTime(2024, 4, 22, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 5, 5, 7, 54, 41, 465, DateTimeKind.Local).AddTicks(228) });
        }
    }
}
