using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Updatedasmigras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tfilmes_Tcinemas_CinemaId",
                table: "Tfilmes");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Tfilmes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tfilmes_Tcinemas_CinemaId",
                table: "Tfilmes",
                column: "CinemaId",
                principalTable: "Tcinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tfilmes_Tcinemas_CinemaId",
                table: "Tfilmes");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Tfilmes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tfilmes_Tcinemas_CinemaId",
                table: "Tfilmes",
                column: "CinemaId",
                principalTable: "Tcinemas",
                principalColumn: "Id");
        }
    }
}
