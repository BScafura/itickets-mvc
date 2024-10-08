using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Umanovamigracaoparaoafonso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tatores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FotoProfile",
                table: "Tatores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Tatores",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tatores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FotoProfile",
                table: "Tatores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Tatores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
