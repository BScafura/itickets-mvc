using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class _1234novasmigras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Tfilmes",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
                values: new object[] { new DateTime(2024, 5, 8, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 4, 18, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5359), new DateTime(2024, 4, 28, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 4, 28, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5368), new DateTime(2024, 4, 18, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 4, 18, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5376), new DateTime(2024, 5, 1, 13, 29, 36, 5, DateTimeKind.Local).AddTicks(5374) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Tfilmes",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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
                values: new object[] { new DateTime(2024, 5, 8, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 4, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 4, 28, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 4, 28, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 4, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 4, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3821), new DateTime(2024, 5, 1, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3819) });
        }
    }
}
