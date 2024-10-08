using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Novamigradotrab123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 11, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2721), new DateTime(2024, 4, 21, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 4, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2730), new DateTime(2024, 5, 1, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2735), new DateTime(2024, 5, 1, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2739), new DateTime(2024, 4, 21, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 29, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2743), new DateTime(2024, 4, 21, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2747), new DateTime(2024, 5, 4, 3, 24, 39, 716, DateTimeKind.Local).AddTicks(2746) });
        }
    }
}
