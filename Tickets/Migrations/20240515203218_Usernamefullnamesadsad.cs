using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Usernamefullnamesadsad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "986de12c-e440-48ed-9f08-c2a75712d778");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca292b3-4cf5-44d9-b72f-b256e60e18f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e9b5713-5496-4489-bad2-e4dbb5ccf5fa", null, "User1", "USER1" },
                    { "984ca3cf-0451-42ad-9bd3-d79618755eb0", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2097), new DateTime(2024, 5, 5, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2104), new DateTime(2024, 5, 15, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 5, 15, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 5, 5, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2116), new DateTime(2024, 5, 5, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 5, 18, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2119) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e9b5713-5496-4489-bad2-e4dbb5ccf5fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "984ca3cf-0451-42ad-9bd3-d79618755eb0");

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
    }
}
