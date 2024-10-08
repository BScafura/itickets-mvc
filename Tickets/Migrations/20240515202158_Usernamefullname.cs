using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Usernamefullname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279284e6-8fe5-47fc-b689-10af908d436c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cc2f5c1-11fb-471d-9507-81c40fb1b156");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "986de12c-e440-48ed-9f08-c2a75712d778", null, "Admin", "ADMIN" },
                    { "fca292b3-4cf5-44d9-b72f-b256e60e18f0", null, "User1", "USER1" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 5, 5, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 5, 15, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 5, 15, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 5, 5, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(106), new DateTime(2024, 5, 5, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 5, 18, 21, 21, 57, 806, DateTimeKind.Local).AddTicks(108) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "986de12c-e440-48ed-9f08-c2a75712d778");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca292b3-4cf5-44d9-b72f-b256e60e18f0");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "279284e6-8fe5-47fc-b689-10af908d436c", null, "Admin", "ADMIN" },
                    { "3cc2f5c1-11fb-471d-9507-81c40fb1b156", null, "User1", "USER1" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 5, 5, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 5, 15, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 5, 15, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 5, 5, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 5, 5, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 5, 18, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8850) });
        }
    }
}
