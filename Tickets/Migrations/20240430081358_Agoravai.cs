using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Agoravai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 4, 20, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 3, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 4, 30, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 7, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 4, 30, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 25, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 4, 20, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 28, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 4, 20, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 20, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 5, 3, 9, 13, 57, 598, DateTimeKind.Local).AddTicks(4625) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 4, 19, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 4, 29, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 6, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(101), new DateTime(2024, 4, 29, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 24, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(105), new DateTime(2024, 4, 19, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(109), new DateTime(2024, 4, 19, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 5, 2, 15, 32, 31, 984, DateTimeKind.Local).AddTicks(112) });
        }
    }
}
