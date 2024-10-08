using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class MaisUmaMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 5, 8, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1655), new DateTime(2024, 4, 18, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1663), new DateTime(2024, 4, 28, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1667), new DateTime(2024, 4, 28, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 4, 18, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1676), new DateTime(2024, 4, 18, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1680), new DateTime(2024, 5, 1, 13, 32, 41, 775, DateTimeKind.Local).AddTicks(1679) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
