using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Novamigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 5, 4, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 5, 14, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 5, 14, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 5, 4, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 5, 4, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 5, 17, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9463) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
