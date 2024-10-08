using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class novasaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MyProperty1",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Nome",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty1",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 5, 14, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 5, 14, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9169), new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 3, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 5, 17, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9175) });
        }
    }
}
