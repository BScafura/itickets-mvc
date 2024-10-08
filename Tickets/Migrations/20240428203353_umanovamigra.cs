using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class umanovamigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 4, 18, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 4, 28, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 4, 28, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5273), new DateTime(2024, 4, 18, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5277), new DateTime(2024, 4, 18, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 5, 1, 21, 33, 52, 833, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Tprodutores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FotoProfile",
                value: "http://dotnethow.net/images/producers/producer-1.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(47), new DateTime(2024, 4, 18, 14, 4, 37, 792, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(54), new DateTime(2024, 4, 28, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 4, 28, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 4, 18, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 4, 18, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 5, 1, 14, 4, 37, 793, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Tprodutores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FotoProfile",
                value: "http://dotnethow.net/images/produtores/producer-1.jpeg");
        }
    }
}
