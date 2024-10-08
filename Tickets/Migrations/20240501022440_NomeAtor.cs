using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class NomeAtor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Tatores",
                newName: "NomeAtor");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tprodutores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FotoProfile",
                table: "Tprodutores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Tprodutores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tcinemas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Tcinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeAtor",
                table: "Tatores",
                newName: "Nome");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tprodutores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FotoProfile",
                table: "Tprodutores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Tprodutores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tcinemas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Tcinemas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
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
    }
}
