using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Novamigrasdads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "AspNetUsers",
                newName: "FullName");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 5, 4, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 17, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1768), new DateTime(2024, 5, 14, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1773), new DateTime(2024, 5, 14, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1777), new DateTime(2024, 5, 4, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 5, 4, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 3, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1785), new DateTime(2024, 5, 17, 22, 26, 21, 369, DateTimeKind.Local).AddTicks(1783) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "Nome");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 5, 4, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 17, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 5, 14, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 5, 14, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 5, 4, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 5, 4, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 3, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1077), new DateTime(2024, 5, 17, 22, 25, 15, 545, DateTimeKind.Local).AddTicks(1076) });
        }
    }
}
