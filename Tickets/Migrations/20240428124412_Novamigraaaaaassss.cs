using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Novamigraaaaaassss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 4, 18, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 4, 28, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 4, 28, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1890), new DateTime(2024, 4, 18, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1894), new DateTime(2024, 4, 18, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1898), new DateTime(2024, 5, 1, 13, 44, 12, 414, DateTimeKind.Local).AddTicks(1897) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 4, 18, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 4, 28, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 4, 28, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 4, 18, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 4, 18, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 5, 1, 13, 36, 9, 143, DateTimeKind.Local).AddTicks(6565) });
        }
    }
}
