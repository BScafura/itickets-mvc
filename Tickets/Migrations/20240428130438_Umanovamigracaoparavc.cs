using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Umanovamigracaoparavc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tcinemas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tcinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
